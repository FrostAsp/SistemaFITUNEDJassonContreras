using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriasClasesGym
{
    public class AfiliacionSede
    {


        //afiliacion sede que necesida un id, la fecha de la afiliacion, el cliente, y la afiliacion cliente sede
        private AfiliacionClienteSede[] afiliacionClienteSede;

        private int idAfiliacion;
        private DateTime datetime;
        private Cliente cliente;


        
        //contuctor para afiliar id, la fecha de la afiliacion, el cliente, y la afiliacion cliente sede
        public AfiliacionSede(int idAfiliacion, DateTime fecha, Cliente objetoCliente, AfiliacionClienteSede[] afiliarSedes)
        {

            this.IdAfiliacion = idAfiliacion;
            this.Datetime = fecha;
            this.Cliente = objetoCliente;
            this.afiliacionClienteSede = afiliarSedes;


        }
       
        public int IdAfiliacion { get => idAfiliacion; set => idAfiliacion=value; }
        public DateTime Datetime { get => datetime; set => datetime=value; }
        public Cliente Cliente { get => cliente; set => cliente=value; }
    }
}
