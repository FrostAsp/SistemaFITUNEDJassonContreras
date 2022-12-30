using SistemaFITUNEDJassonContreras.Datos;
using SistemaFITUNEDJassonContreras.Presentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaFITUNEDJassonContreras
{
    public partial class MenuPrincipal : Form
    {
        public delegate void ClientCarrier(ConexionTcp conexionTcp);
        public event ClientCarrier OnClientConnected;
        public event ClientCarrier OnClientDisconnected;
        public delegate void DataRecieved(ConexionTcp conexionTcp, string data);
        public event DataRecieved OnDataRecieved;

        private TcpListener _tcpListener;
        private Thread _acceptThread;
        private List<ConexionTcp> connectedClients = new List<ConexionTcp>();


        /// ////////////////////////////////////////////////////////
        Thread subprocesoEscuchaClientes;
        //conexion maestra para abrir y cerrar la base de datos
        CONEXIONMAESTRA conexionMaestra = new CONEXIONMAESTRA();
 
        //clases para manipular la base de datos a partir de los from que las necesiten
        /// ////////////////////////////////////
        Dclientes metodosCliente;
        Dsedes metodosSede;
        DsedesClientes metodosSedeClientes;
        DcuposXsede metodosCupoXsede;
        ConsultaLogin consulta;
        DaplicacionCliente metodosAplicacionCliente;
        /////////////////////////////////////////


        public MenuPrincipal()
        {
            InitializeComponent();

            metodosSede = new Dsedes(conexionMaestra);
            consulta = new ConsultaLogin(conexionMaestra);
            metodosCliente = new Dclientes(conexionMaestra);
            metodosSedeClientes = new DsedesClientes(conexionMaestra);
            metodosCupoXsede = new DcuposXsede(conexionMaestra);
            metodosAplicacionCliente = new DaplicacionCliente(conexionMaestra);

        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

            panelBienvenida.Dock = DockStyle.Fill;


            //escucharClientes("127.0.0.1", 15810, consulta);

            OnDataRecieved += MensajeRecibido;
            OnClientConnected += ConexionRecibida;
            OnClientDisconnected += ConexionCerrada;

            EscucharClientes("127.0.0.1", 15810);

        }
        private void MensajeRecibido(ConexionTcp conexionTcp, string datos)
        {
            var paquete = new Paquete(datos);
            string comando = paquete.Comando;
            if (comando == "login")
            {
                string id;

                string contenido = paquete.Contenido;

                List<string> valores = Mapa.Deserializar(contenido);

                //Invoke(new Action(() => id = valores[0]));

                id = valores[0];
                //MessageBox.Show(id + "");


                if (consulta.login_cliente(id))
                {
                    //MessageBox.Show("id validado con exito");
                    string nombreCliente;
                    string nombre1;
                    //Invoke(new Action(() => id = valores[0));
                    nombreCliente = consulta.nombreClienteDisponible(id);

                    List<string> sedesDisponibles = metodosAplicacionCliente.MostrarSedesAfiliadas(id);

                    string sede = sedesDisponibles[0];

                   //MessageBox.Show(string.Join(Environment.NewLine, sedesDisponibles));

                    //MessageBox.Show(valores2 + "");

                    var msgPack = new Paquete("Correcto", nombreCliente);
                    conexionTcp.EnviarPaquete(msgPack);


                    MessageBox.Show(sede +"Datos del servidor");

                    var msgPackSedes = new Paquete("C", sedesDisponibles);
                    conexionTcp.EnviarPaquete(msgPackSedes);


                }
                else
                {
                  
                    var msgPack = new Paquete("Incorrecto", "NO");
                    conexionTcp.EnviarPaquete(msgPack);

                }

                
            }
        }

        private void ConexionRecibida(ConexionTcp conexionTcp)
        {
            lock (connectedClients)
                if (!connectedClients.Contains(conexionTcp))
                    connectedClients.Add(conexionTcp);
            Invoke(new Action(() => label1.Text = string.Format("Clientes: {0}", connectedClients.Count)));
        }

        private void ConexionCerrada(ConexionTcp conexionTcp)
        {
            lock (connectedClients)
                if (connectedClients.Contains(conexionTcp))
                {
                    int cliIndex = connectedClients.IndexOf(conexionTcp);
                    connectedClients.RemoveAt(cliIndex);
                }
            Invoke(new Action(() => label1.Text = string.Format("Clientes: {0}", connectedClients.Count)));
        }

        private void EscucharClientes(string ipAddress, int port)
        {
            try
            {
                _tcpListener = new TcpListener(IPAddress.Parse(ipAddress), port);
                _tcpListener.Start();
                _acceptThread = new Thread(AceptarClientes);
                _acceptThread.Start();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
        }

        private void AceptarClientes()
        {
            do
            {
                try
                {
                    var conexion = _tcpListener.AcceptTcpClient();
                    var srvClient = new ConexionTcp(conexion)
                    {
                        ReadThread = new Thread(LeerDatos)
                    };
                    srvClient.ReadThread.Start(srvClient);

                    if (OnClientConnected != null)
                        OnClientConnected(srvClient);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message.ToString());
                }

            } while (true);
        }
        private void LeerDatos(object client)
        {
            var cli = client as ConexionTcp;
            var charBuffer = new List<int>();

            do
            {
                try
                {
                    if (cli == null)
                        break;
                    if (cli.StreamReader.EndOfStream)
                        break;
                    int charCode = cli.StreamReader.Read();
                    if (charCode == -1)
                        break;
                    if (charCode != 0)
                    {
                        charBuffer.Add(charCode);
                        continue;
                    }
                    if (OnDataRecieved != null)
                    {
                        var chars = new char[charBuffer.Count];
                        //Convert all the character codes to their representable characters
                        for (int i = 0; i < charBuffer.Count; i++)
                        {
                            chars[i] = Convert.ToChar(charBuffer[i]);
                        }
                        //Convert the character array to a string
                        var message = new string(chars);

                        //Invoke our event
                        OnDataRecieved(cli, message);
                    }
                    charBuffer.Clear();
                }
                catch (IOException)
                {
                    break;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message.ToString());

                    break;
                }
            } while (true);

            if (OnClientDisconnected != null)
                OnClientDisconnected(cli);
        }




        private void btn_registrarClientes_Click(object sender, EventArgs e)
        {

            RegistroClientes panelCliente = new RegistroClientes(metodosCliente);

            panel2.Controls.Clear();

            panelCliente.Dock = DockStyle.Fill;

            panel2.Controls.Add(panelCliente);

        }

        private void btn_registrarSedes_Click(object sender, EventArgs e)
        {
            RegistroSedes panelSedes = new RegistroSedes(metodosSede);

            panel2.Controls.Clear();

            panelSedes.Dock = DockStyle.Fill;
            
            panel2.Controls.Add(panelSedes);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ConsultarClientes panelConsultarClientes = new ConsultarClientes(metodosCliente);

            panel2.Controls.Clear();

            panelConsultarClientes.mostrarClientes();

            panelConsultarClientes.Dock = DockStyle.Fill;

            panel2.Controls.Add(panelConsultarClientes);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            ConsultarSedes panelConsultarSedes = new ConsultarSedes(metodosSede);

            panel2.Controls.Clear();

            panelConsultarSedes.mostrarSedes(); 

            panelConsultarSedes.Dock = DockStyle.Fill;

            panel2.Controls.Add(panelConsultarSedes);

        }

        private void btn_registroSedeCliente_Click(object sender, EventArgs e)
        {

            RegistrarSedesClientes panelRegistroSedesClientes = new RegistrarSedesClientes(metodosSedeClientes);

            panel2.Controls.Clear();

            panelRegistroSedesClientes.Dock = DockStyle.Fill;

            panel2.Controls.Add(panelRegistroSedesClientes);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            ConsultarSedesClientes panelConsultarSedesClientes = new ConsultarSedesClientes(metodosSedeClientes);

            panel2.Controls.Clear();

            panelConsultarSedesClientes.Dock = DockStyle.Fill;

            panel2.Controls.Add(panelConsultarSedesClientes);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            RegistroCuposXSedes panelRegistroCuposPorSede = new RegistroCuposXSedes(metodosCupoXsede);
            
            panel2.Controls.Clear();

            panelRegistroCuposPorSede.Dock = DockStyle.Fill;

            panel2.Controls.Add(panelRegistroCuposPorSede);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            ConsultarCuposPorSedes panelConsultaCursosPorSedes = new ConsultarCuposPorSedes(metodosCupoXsede);

            panel2.Controls.Clear();

            panelConsultaCursosPorSedes.Dock = DockStyle.Fill;

            panel2.Controls.Add(panelConsultaCursosPorSedes);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            DatosImportantes panelDatosImportantes = new DatosImportantes();

            panel2.Controls.Clear();

            panelDatosImportantes.Dock = DockStyle.Fill;

            panel2.Controls.Add(panelDatosImportantes);


        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
