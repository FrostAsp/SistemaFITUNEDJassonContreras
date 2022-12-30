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
    public partial class ConsultarCuposPorSedes : UserControl
    {
        //instancia de la clase que manipulara todo lo referente a la base de datos
        DcuposXsede metodo;

        public ConsultarCuposPorSedes(DcuposXsede metodo) //traemos el vector con el que ocupamos trabajar
        {
            InitializeComponent();
            
            this.metodo = metodo;

            mostrarCuposPorSedes();
        }

        public void mostrarCuposPorSedes()
        {
            //creamos un objeto de la clase datatable 
            DataTable dt = new DataTable();
            //llenamos el objeto con el metodo por referencia 
            metodo.mostrarListaCuposXSede(ref dt);
            //cargamos el datagrivie con el dato cargado por ref
            dataGridView_CuposXSedes.DataSource = dt;

            //validamos que existan datos en bd para mostrar los label
            if (metodo.existenCupos())
            {
                //se muestran que existen clientes
                label2_disponibles.Visible = true;
                label2_disponibles.Visible = true;
                label1_noDisponibles.Visible = false;
            }
            else
            {
                MessageBox.Show("No se an ingresado CuposSedes");
                label2_disponibles.Visible = true;
                label2_disponibles.Visible = false;
                label1_noDisponibles.Visible = true;
               
            }


        }
    }

}
