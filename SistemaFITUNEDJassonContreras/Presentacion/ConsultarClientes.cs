using LibreriasClasesGym;
using SistemaFITUNEDJassonContreras;
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
    public partial class ConsultarClientes : UserControl
    {
   
        //instancia de clase que manipula la base de datos para clientes
        Dclientes metodo;
       
        public ConsultarClientes(Dclientes metodo) // parametro necesario para trabajar con este vector 
        {
            InitializeComponent();

            this.metodo = metodo;
           
        }

        public void mostrarClientes() // mostrar clientes
        {
            //objeto datatable para llenar la referencia del metodo que cargara los datos
            DataTable dt = new DataTable();

            metodo.mostrarClientes(ref dt);
            //llenado del datagrivie  con la referencia dt
            dataGridView_ConsultarClientes.DataSource=dt;

            //validamos si existen datos en la tabla clientes para mostrar los label
             if (metodo.existenClientes())//se valida que existan clientes
             {

                label1_clientes.Visible = true;
                label2_disponibles.Visible = true;
                label1_noDisponibles.Visible = false;

            }
            else//de lo contrario le hacemos ver al cliente que no hay datos en dicha tabla
             {

                //sino hay clientes se manda por pantalla el problema y se activan los label para mostrar el mensaeje
                MessageBox.Show("No se an ingresado Sedes");
                label1_clientes.Visible = true;
                label2_disponibles.Visible = false;
                label1_noDisponibles.Visible = true;

            }

        }
    }
}
