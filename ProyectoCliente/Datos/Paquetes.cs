using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCliente.Datos
{
    public class Paquetes
    {
        public static Paquete LoginOk(string respuesta)
        {
            return new Paquete(respuesta);
        }

    }
}
