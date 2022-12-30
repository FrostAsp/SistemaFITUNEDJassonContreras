using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriasClasesGym
{
    public class Cliente
    {

        //datos que se deben registrar en clientes
        private string identificador;
        private string nombre;
        private string primerApellido;
        private string segundoApellido;
        private DateTime fechaNacimiento;
        private DateTime fechaIngreso;
        private char genero; 

        //get para poder consultar y set para modificar
        public string Identificador { get => identificador; set => identificador=value; }
        public string Nombre { get => nombre; set => nombre=value; }
        public string PrimerApellido { get => primerApellido; set => primerApellido=value; }
        public string SegundoApellido { get => segundoApellido; set => segundoApellido=value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento=value; }
        public char Genero { get => genero; set => genero=value; }

 
        public DateTime FechaIngreso { get => fechaIngreso; set => fechaIngreso=value; }

        public Cliente()
        {



        }
}

}
