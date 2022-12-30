using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriasClasesGym
{
    public class CuposPorSede
    {
        
        private DateTime fecha;
        private int CuposDisponibles;
        private int idSede;
      
        public DateTime Fecha { get => fecha; set => fecha=value; }
        public int CuposDisponibles1 { get => CuposDisponibles; set => CuposDisponibles=value; }
        public int IdSede { get => idSede; set => idSede=value; }


        public CuposPorSede()
        {

        }

    }


}
