using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFITUNEDJassonContreras.Datos
{
    public class Paquete
    {

        public string Comando;

        public string Contenido;

        List<string> listaSedes = new List<string>();

        public Paquete(string comando, string contenido)
        {

            this.Comando = comando;
            this.Contenido = contenido;


        }
        public Paquete(string comando, List<string> listaSedes)
        {
            this.Comando = comando;

            this.listaSedes = listaSedes;
        }



        //metodo para empaquetar bajo la estructura de comando: contenido
        public Paquete(string datos)
        {
            //se devuelve la posicion que tiene los dos puntos
            int separadorIndex = datos.IndexOf(":", StringComparison.Ordinal);

            //el comando se empieza a dividr desde la posicion 0 hasta el separador osea :
            Comando = datos.Substring(0, separadorIndex);   
            //el contenido por ende se comienza a sacar desde el separado mas 1 posicion despues
            Contenido = datos.Substring(Comando.Length + 1);
        }

        public string Serializar()
        {

            return string.Format("{0}:{1}",Comando, Contenido);

        }

        public static implicit  operator string(Paquete paquete)
        {
            return paquete.Serializar();

        }

    }
}
