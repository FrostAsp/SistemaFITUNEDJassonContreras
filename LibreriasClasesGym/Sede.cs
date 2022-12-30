using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriasClasesGym
{
    public class Sede
    {
        //modificadores de acceso privados para solo ser usados por medio de sus get y set
        private int id;
        private string nombre;
        private string direccion;
        private bool estado;
        private string telefono;

        public int Id { get => id; set => id=value; }
        public string Nombre { get => nombre; set => nombre=value; }
        public string Direccion { get => direccion; set => direccion=value; }
        public bool Estado { get => estado; set => estado=value; }
        public string Telefono { get => telefono; set => telefono=value; }

        public Sede()
        {
           

        }
       
       

    }
}
