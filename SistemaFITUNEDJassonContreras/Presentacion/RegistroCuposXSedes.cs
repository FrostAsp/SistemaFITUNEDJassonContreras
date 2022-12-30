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
    public partial class RegistroCuposXSedes : UserControl
    {
        //instancia de la clase para manipular la base de datos
        DcuposXsede metodo;

        public RegistroCuposXSedes(DcuposXsede metodo)
        {
            InitializeComponent();

            this.metodo = metodo;

            mostrarSedesPorCupos();
            //.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btn_guardarClientes_Click(object sender, EventArgs e)
        {
          if (validarCamposVacios())//validamos que no allan espacios vacios
          {
             MessageBox.Show("No deje campos vacios");
             return;
          }
          else// de lo contrario ahora si ingresamos
          {
                int idCupoPorSede = int.Parse(textBox_idSede.Text);
                
                //validamos que el id cupo no sea repetido
                if (metodo.idCupoPorSedeRepetido(idCupoPorSede) != null)
                {
                    MessageBox.Show("Ya existe un Registro de Cupos con este mismo id, cambielo por favor antes de continuar");
                    return;
                }
                else//sino procedemos a realizar la afiliacion
                {

                    CuposPorSede dato = new CuposPorSede();

                    dato.IdSede = int.Parse(textBox_idSede.Text);
                    dato.Fecha = dateTimePicker_fechaNacimiento.Value;
                    dato.CuposDisponibles1 = int.Parse(textBox_CuposDisponibles.Text);

                    if (metodo.ingresarCuposXSede(dato))
                    {
                        MessageBox.Show("Cupos ingresados con exito");
                    }
                    limpiar();

                }
          }   
        }

        public void limpiar()
        {
            textBox_idSede.Clear();
            textBox_CuposDisponibles.Clear();
        }

        public void mostrarSedesPorCupos()
        {
            DataTable dt = new DataTable();

            metodo.mostrarCuposXSedes(ref dt);
            dataGridView_ConsultarCupos.DataSource = dt;


        }
        public bool validarCamposVacios()
        {
            bool textobox_vacios = false;//volvemos a condicionar que los text box vacios es falso

            if(string.IsNullOrEmpty(textBox_idSede.Text) || string.IsNullOrEmpty(textBox_CuposDisponibles.Text))// si es cierto
            {

                return  textobox_vacios = true; //condicionamos que la condicion es verdadera
            }

            return textobox_vacios;// de lo contrario no hay espacios vacios

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

        private void textBox_CuposDisponibles_KeyPress(object sender, KeyPressEventArgs e)
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
