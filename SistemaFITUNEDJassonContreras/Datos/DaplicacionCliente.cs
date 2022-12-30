using LibreriasClasesGym;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaFITUNEDJassonContreras.Datos
{
    public class DaplicacionCliente
    {

        CONEXIONMAESTRA conexionMaestra;


        public DaplicacionCliente(CONEXIONMAESTRA conexionMaestra)
        {
            this.conexionMaestra = conexionMaestra;

        }

        public List<string> MostrarSedesAfiliadas(string idCliente)
        {
            string consulta = "SELECT s.Nombre FROM AfiliacionSede afs INNER JOIN Sede s ON afs.IdSede = s.IdSede INNER JOIN Cliente c ON  c.IdCliente = afs.IdCliente where afs.IdCliente =" + idCliente;

            List<string> lista = new List<string>();    

            try
            {
                conexionMaestra.abrir();
                SqlCommand cmd = new SqlCommand(consulta, conexionMaestra.conectar);

                SqlDataReader registro = cmd.ExecuteReader();

             
                while (registro.Read())
                {

                    lista.Add(registro["Nombre"].ToString());
                    
                }

                //este metodo retornada el nombre de todas las sedes
                //manana tenes que buscar una forma de hacer que se envien en el paquete de vuelta
                //al cliente los datos del nombreClientes +  estos nombres de las sedes
                //luego que desde el metodo que abre la pantalla de aplicacion cliente
                //del proyecto cliente enviar como parametro estos nombres para que sean cargados 
                //apenas se abran
                //MessageBox.Show(lista[0]);
               
            }
            catch (Exception e)
            {

                MessageBox.Show("Error en el metodo MostrarSedesAfiliadas :" + e);

            }
            finally
            {
                conexionMaestra.cerrar();

            }

            return lista;

        }

        public List<string> FechaCupos(string idCliente)
        {
            string consulta = "Select a.FechaCupo  FROM CupoSede a  INNER JOIN AfiliacionSede s ON a.IdSede = s.IdSede INNER JOIN Cliente c  ON c.IdCliente = s.IdCliente where (a.Cupos >0) and s.IdCliente = " + idCliente;

            List<string> lista = new List<string>();

            try
            {
                conexionMaestra.abrir();
                SqlCommand cmd = new SqlCommand(consulta, conexionMaestra.conectar);

                SqlDataReader registro = cmd.ExecuteReader();


                while (registro.Read())
                {

                    lista.Add(registro["FechaCupo"].ToString());

                    return lista;

                }
            }
            catch (Exception e)
            {

                MessageBox.Show("Error en el metodo FechaCupos :" + e);

            }
            finally
            {
                conexionMaestra.cerrar();
            }

            return null;

        }

        public bool ingresarReserva(Reserva reserva)
        {

            string consulta = "INSERT INTO Reserva (IdReserva, IdSede, IdCliente, Fecha) " +
            "values('"+reserva.IdReserva+"', '"+reserva.IdSede+"', '"+reserva.IdCliente+"', '"+reserva.FechaReserva+"')";
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











    }
}
