
using LibreriasClasesGym;
using SistemaFITUNEDJassonContreras.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SistemaFITUNEDJassonContreras.Presentacion
{
    public partial class RegistroClientes : UserControl
    {
        //instancia que servira para manipular la base de datos desde un metodo
        Dclientes metodo;

        //traemos los vectores que ocupamos y una instancia de la clase vectores para sus acumuladores
        public RegistroClientes(Dclientes metodo)
        {
            InitializeComponent();
            
            this.metodo = metodo;
            
            comboBox_genero.DropDownStyle = ComboBoxStyle.DropDownList;//bloqueamos comobo box

        }
    
        private void textBox_idCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >=58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros Por Favor,");
                e.Handled = true;
                return;
            }
        }
 
        public void limpiar()//limpiamos 
        {
            textBox_identificadorCliente.Clear();
            textBox_NombreCliente.Clear();
            textBox_PrimerApellido.Clear();
            textBox_segundoApellido.Clear();
        }

        public bool validarCamposVacios()
        {

            bool textobox_vacios = false;//inicializamos en falso la condicion de que existan espacios vacios

            if (string.IsNullOrEmpty(textBox_identificadorCliente.Text) || string.IsNullOrEmpty(textBox_NombreCliente.Text)  ||
                string.IsNullOrEmpty(textBox_PrimerApellido.Text) ||  string.IsNullOrEmpty(textBox_segundoApellido.Text)
                ||  string.IsNullOrEmpty(comboBox_genero.Text))//al existir 
            {
                //se retorna verdadero
                textobox_vacios = true;
            }

            return textobox_vacios;//de lo contrario se retorna falso
        }
        private void btn_guardarSedes_Click(object sender, EventArgs e)
        {
            ingresarClienteNuevo();
        }

        //ingreso clientes a la base de datos
        public void ingresarClienteNuevo()
        {
            if (validarCamposVacios())//validamos que no vallan espacios vacios
            {
                MessageBox.Show("Llene todos los espacios antes de continuar");
                return;

            }
            else //sino procedemos hacer otra validacion
            {
                string idCliente = textBox_identificadorCliente.Text;
                //validamos que el id cliente ya no alla sido ingresado con anterioridad
                if (metodo.idClienteRepetido(idCliente)!= null)
                {
                    MessageBox.Show("Ya existe un cliente con este mismo id, cambielo por favor antes de continuar");
                    return;
                }
                else//sino se procede hacer el ingreso de los datos
                {
                    //creamos una instancia de cliente para mandar los datos que se guardar despues
                    Cliente cliente = new Cliente();

                    //envio
                    cliente.Identificador = textBox_identificadorCliente.Text;
                    cliente.Nombre = textBox_NombreCliente.Text;
                    cliente.PrimerApellido = textBox_PrimerApellido.Text;
                    cliente.SegundoApellido =  textBox_segundoApellido.Text;

                    if (comboBox_genero.SelectedIndex == 0)//sacamos el index para validar que se selecciono
                    {
                        cliente.Genero = 'M';

                    }
                    else
                    {
                        cliente.Genero = 'F';

                    }
                    //guardamos los demas datos
                    cliente.FechaNacimiento = dateTimePicker_fechaNacimiento.Value;
                    cliente.FechaIngreso = dateTimePicker_fechaIngreso.Value;

                    if (metodo.ingresarCliente(cliente))//llamamos al metodo que ingresa los datos
                    {//le pasamos una la referencia del objeto cliente para manipular los datos

                        MessageBox.Show("Cliente Registrado con exito");

                    }
                    //limpiamos las cajas
                    limpiar();
                }     
            }
        }
    }
}
