using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriasClasesGym
{
    public class AfiliacionClienteSede
    {

        //atributos para la afiliacion

        private int idAfiliacion;
        private DateTime fechaAfiliacion;
        private string idCliente;
        private int idSede;

        //uso de get y set para acceder a los atributos privados
        public int IdAfiliacion { get => idAfiliacion; set => idAfiliacion=value; }
        public DateTime FechaAfiliacion { get => fechaAfiliacion; set => fechaAfiliacion=value; }
        public string IdCliente { get => idCliente; set => idCliente=value; }
        public int IdSede { get => idSede; set => idSede=value; }


        public AfiliacionClienteSede()
        {



        }
    }
}
