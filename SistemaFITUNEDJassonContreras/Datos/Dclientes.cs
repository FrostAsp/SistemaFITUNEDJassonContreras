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
    public class Dclientes
    {
        CONEXIONMAESTRA conexionMaestra;
        public Dclientes(CONEXIONMAESTRA conexionMaestra)
        {

            this.conexionMaestra = conexionMaestra;

        }

        public bool ingresarCliente(Cliente cliente)
        {

            string consulta = "INSERT INTO Cliente (IdCliente, Nombre, PrimerApellido, SegundoApellido, FechaNacimiento, Genero, FechaIngreso) " +
            "values('"+cliente.Identificador+"', '"+cliente.Nombre+"', '"+cliente.PrimerApellido+"', '"+cliente.SegundoApellido+"', '"+cliente.FechaNacimiento.Date.ToString("yyyyMMdd")+"', '"+cliente.Genero+"', '"+cliente.FechaIngreso.Date.ToString("yyyyMMdd")+"')";
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

        public string idClienteRepetido(string idCliente)
        {
            string consulta = "SELECT IdCliente from Cliente where IdCliente = " + idCliente+ "";
 
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

        public bool existenClientes()
        {
            string consulta = "select * from Cliente";

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

        public void mostrarClientes(ref DataTable dt)
        {
            string consulta = "select * from Cliente";
            
            try
            {
                string existenDatos;
 
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
