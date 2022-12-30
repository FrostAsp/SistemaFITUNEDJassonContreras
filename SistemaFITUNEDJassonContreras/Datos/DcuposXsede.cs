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
    public class DcuposXsede
    {
        CONEXIONMAESTRA conexionMaestra;
        public DcuposXsede(CONEXIONMAESTRA conexionMaestra)
        {

            this.conexionMaestra = conexionMaestra; 


        }

        public string idCupoPorSedeRepetido(int idCupo)
        {
            string consulta = "SELECT IdSede FROM CupoSede where IdSede =" +idCupo;

            //string consulta = "SELECT a.Estado, c.IdSede FROM Sede a INNER JOIN CupoSede c ON (a.Estado = 0) or c.IdSede ="+ idCupo;
            try
            {
                string cliente;
                conexionMaestra.abrir();
                SqlCommand cmd = new SqlCommand(consulta, conexionMaestra.conectar);

                cmd.ExecuteNonQuery();

                cliente = cmd.ExecuteScalar()!= null ? cmd.ExecuteScalar().ToString() : null;

                return cliente;

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

        public void mostrarCuposXSedes(ref DataTable dt)
        {

            string consulta = "SELECT IdSede, Nombre, Estado FROM Sede where Estado = 1";

            try
            {

                conexionMaestra.abrir();
                SqlDataAdapter cmd = new SqlDataAdapter(consulta, conexionMaestra.conectar);

                cmd.Fill(dt);


            }
            catch (Exception e)
            {

                MessageBox.Show("fallo el mostrado de los datos por error : "+ e.ToString());

            }
            finally
            {
                conexionMaestra.cerrar();

            }

        }

        public bool ingresarCuposXSede(CuposPorSede dato)
        {
            string consulta = "INSERT INTO CupoSede (IdSede, FechaCupo, Cupos)" +
             "values('"+dato.IdSede+"', '"+dato.Fecha.Date.ToString("yyyyMMdd")+"', '"+dato.CuposDisponibles1 + "')";

            try
            {
               

                conexionMaestra.abrir();
                SqlCommand cmd = new SqlCommand(consulta, conexionMaestra.conectar);
                cmd.ExecuteNonQuery();

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

        public bool existenCupos()
        {
            string consulta = "Select a.IdSede, a.Nombre, a.Direccion, a.Telefono, a.Estado,c.FechaCupo,c.Cupos  from Sede a INNER JOIN CupoSede c on a.IdSede = c.IdSede";

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

        public void mostrarListaCuposXSede(ref DataTable dt)
        {

            string consulta = "Select a.IdSede, a.Nombre, a.Direccion, a.Telefono, a.Estado,c.FechaCupo,c.Cupos  from Sede a INNER JOIN CupoSede c on a.IdSede = c.IdSede";

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
