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
    public partial class ConsultarSedesClientes : UserControl
    {

        DsedesClientes metodo;
        //instancias necesarias para trabajar en este from junto con los parametros para traer dichos vectores
        public ConsultarSedesClientes(DsedesClientes metodo)
        {
            InitializeComponent();


            this.metodo = metodo;

            //mostramos apenas se corra el programa 
            mostrarAfiliacionSedes();
            mostrarAfiliacionClienteSede();
        }

        private void ConsultarSedesClientes_Load(object sender, EventArgs e)
        {
        }

        public void mostrarAfiliacionSedes()
        {
            DataTable dt = new DataTable();

            
            metodo.mostrarAfiliacionSedes(ref dt);
            dataGridView_Sedes.DataSource = dt;

        }

        public void mostrarAfiliacionClienteSede()
        {

            DataTable dt = new DataTable();

            metodo.mostrarAfiliacionSedes(ref dt);
            dataGridView_AfiliacionClienteSede.DataSource = dt;

            

        }

        private void dataGridView_Sedes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}