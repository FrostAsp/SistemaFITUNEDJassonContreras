using LibreriasClasesGym;
using SistemaFITUNEDJassonContreras.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaFITUNEDJassonContreras.Presentacion
{
    public partial class RegistroSedes : UserControl
    {
       
        
        Dsedes metodo;

        //traemos la clase que manipulara la base de datos para la ingresion de las sedes
        public RegistroSedes(Dsedes metodo)
        {
            InitializeComponent();

            this.metodo = metodo;   
            comboBox_estado.DropDownStyle = ComboBoxStyle.DropDownList;//bloqueamos comobo box
        }
        

        private void btn_guardarSedes_Click(object sender, EventArgs e)
        {
            try
            {

                if (validarCamposVacios())//validamos espacios vacios
                {
                    MessageBox.Show("No deje campos vacios");
                }
                else// de lo contrario hacemos una validacion adicional
                {//validamos que el id sede ya no alla sido registrado con anterioridad
                    int idSede = int.Parse(textBox_idSede.Text);

                    if (metodo.idSedeRepetido(idSede) != null)
                    {
                        MessageBox.Show("Ya existe una Sede con este mismo id, cambielo por favor antes de continuar");
                        return;

                    }
                    else//sino se procede hacer la afiliacion
                    {
                        ingresarSedes();

                    }
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Error");

            }    
            
        }

        public void ingresarSedes()
        {
            Sede sede = new Sede();
           
            //sacamos los datos de cada componente que se usan para ingresar por la interfaz 
            bool estado;

       
            sede.Id = int.Parse(textBox_idSede.Text);
            sede.Nombre = textBox_NombreSede.Text;
            sede.Direccion = textBox_DireccionSede.Text;

            if (comboBox_estado.SelectedItem == "Activo")// seleccionamos el item del comob box
            {
               sede.Estado = estado = true;
            }
            else
            {
                sede.Estado = estado = false;
            }

            sede.Telefono = textBox_telefonoSede.Text;

            if(metodo.ingresarSede(sede))
            {
                MessageBox.Show("Sede Registrada Con exito");
            }
            limpiar();  
             
        }

        public bool validarCamposVacios()
        {
            bool textobox_vacios = false; //condicionamos que los espacios vacios son falsos

            if (string.IsNullOrEmpty(textBox_idSede.Text) || string.IsNullOrEmpty(textBox_NombreSede.Text)  ||
                string.IsNullOrEmpty(textBox_telefonoSede.Text) ||  string.IsNullOrEmpty(textBox_DireccionSede.Text)
                ||  string.IsNullOrEmpty(comboBox_estado.Text))
            {
                //si se cumple la condicion existen esapcios vacios se retorna true
                textobox_vacios = true;
               
            }

            return textobox_vacios;// de lo contrario la condicion sigue siendo falsa
        }


        public void limpiar()//limpiamos campos
        {
            textBox_idSede.Clear();
            textBox_NombreSede.Clear();
            textBox_DireccionSede.Clear();
            textBox_telefonoSede.Clear();


        }


        private void textBox_idSede_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >=58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros Por Favor,");
                e.Handled = true;
                return;

            }

        }
    }
}
