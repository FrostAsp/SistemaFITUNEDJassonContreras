using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCliente.Datos
{
    public class Paquete
    {
        public string Comando;
        public string Contenido;

        public List<string> listaSedes;

        public Paquete()
        {

        }

        public Paquete(string comando, string contenido)
        {
            Comando = comando;
            Contenido = contenido;
        }

        public Paquete(string comando, List<string> listaSedes)
        {
            this.Comando = comando;

            this.listaSedes = listaSedes;
        }





        public Paquete(string datos) // ej: login:usuario,contrasena
        {
            int sepIndex = datos.IndexOf(":", StringComparison.Ordinal);
            Comando = datos.Substring(0, sepIndex);
            Contenido = datos.Substring(Comando.Length + 1);
        }

        public string Serializar()
        {
            return string.Format("{0}:{1}", Comando, Contenido);
        }

        public static implicit operator string(Paquete paquete)
        {
            return paquete.Serializar();
        }
    }
}
