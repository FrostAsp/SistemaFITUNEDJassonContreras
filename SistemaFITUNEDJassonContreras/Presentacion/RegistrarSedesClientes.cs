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

namespace SistemaFITUNEDJassonContreras
{
    public partial class RegistrarSedesClientes : UserControl
    {


        DsedesClientes metodo;
        
        //instanciamos y traemos por el contructor todos los vectores que ocupamos para trabajar
        public RegistrarSedesClientes(DsedesClientes metodo)
        {
            InitializeComponent();

            this.metodo = metodo;

            mostrarClientesYSedesDisponibles();

            //bloqueamos que se pueda editar los comboo box
            comboBox_SedesDisponibles.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_clientesDisponibles.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void RegistrarSedesClientes_Load(object sender, EventArgs e)
        {

        }
        public int identificadorAfiliacion()//metodo que retorna un id de 0 a 1000
        {
            int afiliacion = new Random().Next(0, 10000);
            return afiliacion;
        }

        //fecha en la que se produjo la afiliacion del cliente
        public DateTime fechaIngreso()
        {
            DateTime datetime = DateTime.Now;
            return datetime;

        }

        public void mostrarClientesYSedesDisponibles()
        {
            //objetos datatable 

            DataTable dt = new DataTable();
            DataTable tb = new DataTable();
            //llenado de los datos en la base de datos
            metodo.mostrarSedesClientes(ref dt,ref tb);
            //llenado del datagrivie clientes disponibles con la ref del metodo consultar clientes sedes
            dataGridView_ConsultarClientesDisponibles.DataSource=dt;
            //llenaod del datagrvie sedes disponibles con la ref del metodo consultarsedes disponibles
            dataGridView_ConsultarSedesDisponibles.DataSource = tb;

            //mostrado en los comobo box de los clientes y sedes
            metodo.mostrarIDClientesDisponibles(comboBox_clientesDisponibles);
            metodo.mostrarIDSedesDisponibles(comboBox_SedesDisponibles);
            
        }
        private void AgregarSedes_Click(object sender, EventArgs e)
        {
            try
            {

                if (comboBoxVacios())//validamos que no esten los comobo box vacios
                {
                    MessageBox.Show("Por favor seleccione un cliente y una sede ");
                    return;
                }
                else//si se cumple se procede afiliarSede
                {
                    string idCliente = comboBox_clientesDisponibles.Text;
                    int idSede = int.Parse(comboBox_SedesDisponibles.Text);

                    AfiliacionClienteSede afiliacion = new AfiliacionClienteSede();

                    afiliacion.IdAfiliacion = identificadorAfiliacion();
                    afiliacion.FechaAfiliacion = fechaIngreso();
                    afiliacion.IdCliente = comboBox_clientesDisponibles.Text;
                    afiliacion.IdSede = int.Parse(comboBox_SedesDisponibles.Text);

                    metodo.afiliacionSedeCliente(afiliacion);
                    
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Error");

            }
          

           
       
        }

        public bool comboBoxVacios()
        {
            bool comboboxVacios  = false; //combobox vacios falso 
            if (string.IsNullOrEmpty(comboBox_clientesDisponibles.Text) || string.IsNullOrEmpty(comboBox_SedesDisponibles.Text))
            {
                //se intenta convertir la cadena del combobox a string si la cadena es nula se cumplira la condicion
                comboboxVacios = true;

            }

            return comboboxVacios;//sino se retorna que los combo box no estan vacios


        }
        private void agregarAfiliacionClienteSede_Click(object sender, EventArgs e)
        { 


        }


        public void validarllenadoAfiliacionClienteSede(Sede sede)
        {


        }


        public void AfiliacionClienteSede(Sede sede)//afiliacion sedes a afiliacion cliente sede
        {

           
        }

        private void dataGridView_ConsultarClientesDisponibles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}
