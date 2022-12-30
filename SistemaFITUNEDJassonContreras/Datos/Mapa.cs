using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFITUNEDJassonContreras.Datos
{
    public class Mapa
    {
        public static string Serializar(List<string> lista)
        {
            if(lista.Count == 0)
            {
                return null;
            }

            bool primero = true;
            var salida = new StringBuilder();

            foreach (var linea in lista)
            {
                if (primero)
                {
                    salida.Append(linea);
                    primero = false;
                }
                else
                {

                    salida.Append(String.Format(",{0}", linea));

                }
            }
            return salida.ToString();
        }

        public static List<string> Deserializar(string entrada)
        {

            string str = entrada;

            var lista = new List<string>();

            if(string.IsNullOrEmpty(str))
            {
                return lista;
            }

            try
            {
                foreach(var linea in entrada.Split(','))
                {

                    lista.Add(linea);

                }

            }
            catch (Exception)
            {

                return null;
               
            }

            return lista;   
        }






    }
}
