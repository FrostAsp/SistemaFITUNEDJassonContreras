using LibreriasClasesGym;
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
    public class Dsedes
    {
        CONEXIONMAESTRA conexionMaestra;
        public Dsedes(CONEXIONMAESTRA conexionMaestra)
        {
            this.conexionMaestra = conexionMaestra;
        }
        //ingresar sedes a la base de datos
        public bool ingresarSede(Sede sede) 
        {
            string consulta = "INSERT INTO Sede(IdSede,Nombre, Direccion, Estado, Telefono)" +
                "values('"+sede.Id+"', '"+sede.Nombre+"', '"+sede.Direccion+"', '"+sede.Estado+ "', '"+sede.Telefono+"')";
            
            try
            {
                //abrir conexion
                conexionMaestra.abrir();
                SqlCommand cmd = new SqlCommand(consulta, conexionMaestra.conectar);
               
                cmd.ExecuteNonQuery();
                //ingreso del comando 
                return true;

            }
            catch (Exception e)
            {

                MessageBox.Show("ingreso fallido por error : "+ e.ToString());
                return false;
            }
            finally
            {
                conexionMaestra.cerrar();

            }


        }

        public string idSedeRepetido(int idSede)
        {
            string consulta = "SELECT IdSede  FROM Sede where IdSede ="+idSede+"";

            try
            {
                string sede;
                conexionMaestra.abrir();
                SqlCommand cmd = new SqlCommand(consulta, conexionMaestra.conectar);
                cmd.ExecuteNonQuery();

                sede = cmd.ExecuteScalar()!= null ? cmd.ExecuteScalar().ToString() : null;

                return sede;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error que se produce en : "+ e.ToString());
                return null;
            }
            finally
            {
                conexionMaestra.cerrar();

            }

        }

        public bool existenSedes()
        {
            string consulta = "select * from Sede";

            try
            {
                conexionMaestra.abrir();
                SqlCommand cmd = new SqlCommand(consulta, conexionMaestra.conectar);
                cmd.ExecuteNonQuery();

                int existeRegistro = Convert.ToInt32(cmd.ExecuteScalar());

                if (existeRegistro == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }

            }
            catch (Exception e)
            {

                MessageBox.Show("Error que se produce en : "+ e.ToString());
                return false;
            }
            finally
            {
                conexionMaestra.cerrar();

            }

        }

        //mostrados de las sedes por medio de dataGrivie
        public void mostrarSedes(ref DataTable dt)
        {
            //comando select de todos los datos de la tabla sede
            string consulta = "select * from Sede";

            try
            {

                conexionMaestra.abrir();
                SqlDataAdapter cmd = new SqlDataAdapter(consulta, conexionMaestra.conectar);

                cmd.Fill(dt);


            }
            catch (Exception e)
            {

                MessageBox.Show("ingreso fallido por error : "+ e.ToString());

            }
            finally
            {
                conexionMaestra.cerrar();

            }

        }
    }
}
