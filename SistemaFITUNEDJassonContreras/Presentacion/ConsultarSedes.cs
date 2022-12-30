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
    public partial class ConsultarSedes : UserControl
    {
        //instancia de la clase que manipulara la base de datos para las consulta de sede
        Dsedes metodo;

        public ConsultarSedes(Dsedes metodo)// vector con el que se trabajara en este from
        {
            InitializeComponent();

            this.metodo = metodo;
        }

        public void mostrarSedes()
        {
        //objeto de la clase datatable para usarlo para llenar el metodo por referencia
           DataTable dt = new DataTable();

            metodo.mostrarSedes(ref dt);
            //impresion del datagrivie de sedes con la carga de los datos por ref
            dataGridView_ConsultarSedes.DataSource = dt;

            if (metodo.existenSedes())//validamos que existan sedes registradas
            {
                label1_sedes.Visible = true;
                label2_disponibles.Visible = true;
                label1_noDisponibles.Visible = false;
            }
            else
            {    
                //sino se muestra que no hay sedes afiliadas
                MessageBox.Show("No se an ingresado Sedes");
                label1_sedes.Visible = true;
                label2_disponibles.Visible = false;
                label1_noDisponibles.Visible = true;
                           
            }


        }
 
    }

}