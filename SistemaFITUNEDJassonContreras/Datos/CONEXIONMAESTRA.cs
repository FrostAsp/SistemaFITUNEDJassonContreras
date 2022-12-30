using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaFITUNEDJassonContreras.Datos
{
    public class CONEXIONMAESTRA
    {
        public static string conexion = @"Data source=DESKTOP-2GAF31A\SQLEXPRESS; Initial Catalog=FITUNED; Integrated Security=true";

        public SqlConnection conectar;

        public CONEXIONMAESTRA ()
        {
            conectar = new SqlConnection(conexion);
        }

        public void abrir()
        {
           if (conectar.State == ConnectionState.Closed)
           {
                conectar.Open();             
           }

        }

        public void cerrar()
        {
            if (conectar.State == ConnectionState.Open)
            {
                conectar.Close();
            }


        }


    }
}
