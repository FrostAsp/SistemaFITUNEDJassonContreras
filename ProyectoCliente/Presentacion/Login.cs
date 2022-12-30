using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoCliente.Datos;
using ProyectoCliente.Presentacion;
using SistemaFITUNEDJassonContreras.Datos;

namespace ProyectoCliente
{
    public partial class Login : Form
    {
        public static Datos.ConexionTcp conexionTcp = new Datos.ConexionTcp();
        public static string ipaddress = "127.0.0.1";
        public const int puerto = 15810;

        string idCliente;
        //TcpClient cliente;
        List<string> valores;

        AplicacionCliente ventanaAplicacionCliente = new AplicacionCliente();

        public Login()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (!(textfiel_idCliente.Text.Equals(string.Empty)))
            {
                try
                {
                    if (conexionTcp.TcpClient.Connected)
                    {
                        //modificacion de {0}, {1} a solo {0}
                        var msgPack = new Datos.Paquete("login", string.Format("{0}", textfiel_idCliente.Text));
                        conexionTcp.EnviarPaquete(msgPack);
                        idCliente = textfiel_idCliente.Text;
                    }

                }
                catch (SocketException)
                {

                    MessageBox.Show("Verifique que el servidor esté escuchando clientes...", "No es posible conectarse", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else
            {

                MessageBox.Show("Debe ingresar el identificador del cliente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void button_conectar_Click(object sender, EventArgs e)
        {

            //socket_cliente.Start();
            //socket_cliente.Send("1");
            //MessageBox.Show(socket_cliente.Receive());

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button_ssss_Click(object sender, EventArgs e)
        {
            //socket_cliente.Start();
            //socket_cliente.Send("2");
        }
        private void MensajeRecibido(string datos)
        {
            var paquete = new Datos.Paquete(datos);
            string comando = paquete.Comando;

            string contenido = paquete.Contenido;

            MessageBox.Show(comando);

            if (comando == "Correcto")
            {
                //MessageBox.Show("mensaje devuelto, Correcto");
                
                //string contenido = paquete.Contenido;

                //Invoke(new Action(() => label1.Text = string.Format("Respuesta: {0}", contenido)));
                //MessageBox.Show(contenido + "");
                Invoke(new Action(() => abrirAplicacionCliente(contenido)));
            }
         
            if (comando == "C")
            {

                //string sedesContenido = paquete.Contenido;

                valores = paquete.listaSedes;

                MessageBox.Show(valores[0]);

                MessageBox.Show("AbajodeValores");

                //MessageBox.Show(string.Join(Environment.NewLine, valores));

                MessageBox.Show("AbajodeLiSTA");

                //Invoke(new Action(() => mostrarSedesCliente(valores)));

                //mostrarSedesCliente(valores);

                ventanaAplicacionCliente.mostrarSedesAfiliadas(valores);

                MessageBox.Show("anteVentana");
                ventanaAplicacionCliente.Show();
                //MessageBox.Show("mensaje C, recibido");

            }

            if (comando == "Incorrecto")
            {
                MessageBox.Show("mensaje devuelto, Incorrecto");
            }



        }
        private void Login_Load(object sender, EventArgs e)
        {
            conexionTcp.OnDataRecieved += MensajeRecibido;
           
            if (!conexionTcp.Connectar(ipaddress, puerto))
            {
                MessageBox.Show("Error conectando con el servidor!");
                return;
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
           

        }

        public void abrirAplicacionCliente(string nombreCliente)
        {

            //this.Hide();

            //AplicacionCliente ventanaAplicacionCliente = new AplicacionCliente();
            ventanaAplicacionCliente.clienteConecctar(nombreCliente);


            //ventanaAplicacionCliente.mostrarSedesAfiliadas(valores);



            ventanaAplicacionCliente.Show();

        }
    }
}
