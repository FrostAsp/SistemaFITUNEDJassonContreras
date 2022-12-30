using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoCliente.Datos;


namespace ProyectoCliente.Presentacion
{
    public partial class AplicacionCliente : Form
    {

        public static Datos.ConexionTcp conexionTcp = new Datos.ConexionTcp();
        public static string ipaddress = "127.0.0.1";
        public const int puerto = 15810;

        //string idCliente;

        public AplicacionCliente(/*string idCliente*/)
        {
            InitializeComponent();

            //this.idCliente=idCliente;
        }

        private void AplicacionCliente_Load(object sender, EventArgs e)
        {
            //pasar este codigo a un metodo para solo llamarlo y validar que paquete se devolvio
            try
            {
                var paquete = new Paquete();

                string comando = paquete.Comando;

                //validamos que el mensaje devuelto sea el comando reserva
                if(comando == "Reserva")
                {

                    MessageBox.Show("Reserva realizada con Exito");

                }

            }
            catch (Exception )
            {

                MessageBox.Show("Error producido");
            }


        }

        public void mostrarSedesAfiliadas(List<string> lista)
        {
            MessageBox.Show(lista[0]);

            comboBox_sedesDisponibles.DataSource = lista;
            
            //MessageBox.Show(string.Join(Environment.NewLine, lista));

            MessageBox.Show("mensaje llegado al metodo sedes");       
               
        }

        public void clienteConecctar(string nombre)
        {
            ClienteActivo.Text = nombre; 
        }

        private void button_Aceptar_Click(object sender, EventArgs e)
        {
            //validamos que exista una conexion entre el cliente y servidor
            if (conexionTcp.TcpClient.Connected)
            {

                if (comboBoxVacios())
                {

                    MessageBox.Show("Por favor no deje seleccione la sede y la fecha de la cual quiere realizar cupos");
                    return;

                }
                else
                {
                    var msgPack = new Paquete("Reserva", string.Format("{0},{1}", comboBox_sedesDisponibles.Text, comboBox_Fechas.Text));
                    conexionTcp.EnviarPaquete(msgPack);
                }

            }
            else
            {
                MessageBox.Show("Verifique que el servidor esté escuchando clientes...");
            }

        }

        public bool comboBoxVacios()
        {
            bool comboboxVacios = false; //combobox vacios falso 
            if (string.IsNullOrEmpty(comboBox_sedesDisponibles.Text) || string.IsNullOrEmpty(comboBox_Fechas.Text))
            {
                //se intenta convertir la cadena del combobox a string si la cadena es nula se cumplira la condicion
                comboboxVacios = true;

            }

            return comboboxVacios;//sino se retorna que los combo box no estan vacios
        }


    }
}
