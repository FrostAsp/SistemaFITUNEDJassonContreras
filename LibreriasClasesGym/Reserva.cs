using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriasClasesGym
{

    //clase para almacenar las reservas
    public class Reserva
    {
        private int idReserva;
        private int idSede;
        private string idCliente;
        DateTime fechaReserva;

        public int IdReserva { get => idReserva; set => idReserva=value; }
        public int IdSede { get => idSede; set => idSede=value; }
        public string IdCliente { get => idCliente; set => idCliente=value; }
        public DateTime FechaReserva { get => fechaReserva; set => fechaReserva=value; }

    }
}
