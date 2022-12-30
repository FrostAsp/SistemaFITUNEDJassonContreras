using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaFITUNEDJassonContreras.Datos
{
    public class ConsultaLogin
    {

        CONEXIONMAESTRA conexionMaestra;
        string cliente = "";

        string[] nombreClientes = new string[3];
        public ConsultaLogin(CONEXIONMAESTRA conexionMaestra)
        {

            this.conexionMaestra = conexionMaestra;

        }
      

        //metodo para verificar el login ingresado en el proyecto Cliente 
        public string verificarLogin(string idCliente)
        {

            string consulta = "SELECT c.idCliente FROM Cliente c INNER JOIN AfiliacionSede a ON c.IdCliente = a.IdCliente  where c.IdCliente =" + idCliente;

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

                MessageBox.Show("error :" + e);

                return cliente;
                
            }
            finally
            {
                conexionMaestra.cerrar();
            }

        }


        //metodo para retornar un booleano para validar desde el proyecto cliente
        //si dicho cliente fue registrado en la base de datos
        public bool login_cliente(string idCliente)
        {
            bool cliente_Registrado = false;


            if(verificarLogin(idCliente) != null)
            {
                return cliente_Registrado = true;
                MessageBox.Show("Cliente encontrado");
            }
            else
            {
                return cliente_Registrado;
                MessageBox.Show("Cliente no encontrado");
            }

        }

        public string mostrarSedesAfiliadasAlCliente(ComboBox SedesPorCliente)
        {
            string consulta = "SELECT a.Nombre FROM AfiliacionSede c INNER JOIN Sede a  ON c.IdCliente = ";

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


        //metodo que abrira la conexion a la base de datos para el proyecto cliente
        public void abrirConexion()
        {

            conexionMaestra.abrir();

        }
        //metodo que cerrara la conexion a la base de datos para el proyecto cliente
        public void cerrarConexion()
        {

            conexionMaestra.cerrar();

        }

        //metodo del from del proyecto cliente llamado ClienteValidado
        public string nombreClienteDisponible(string idCliente)
        {
            string consulta = "SELECT c.Nombre, c.PrimerApellido, c.SegundoApellido FROM Cliente c INNER JOIN AfiliacionSede a ON c.IdCliente = " + idCliente;
            
            try
            {
                conexionMaestra.abrir();
                SqlCommand cmd = new SqlCommand(consulta, conexionMaestra.conectar);

                SqlDataReader registro = cmd.ExecuteReader();

                string nombre;
                //string primerApellido;
                //string SegundoApellido;

                if (registro.Read())
                {


                    return nombre = registro["Nombre"].ToString() + " " + registro["PrimerApellido"].ToString() + " " +  registro["SegundoApellido"].ToString();

                    //primerApellido = registro["PrimerApellido"].ToString();

                    //SegundoApellido = registro["SegundoApellido"].ToString();
                    ////Label.text = registro["PrimerApellido"].ToString();
                    ////nombreClientes[2] = registro["SegundoApellido"].ToString();

                    //return datosCliente = nombre + primerApellido + SegundoApellido;
                }

            

            }
            catch (Exception e)
            {

                MessageBox.Show("Se produjo un error :" + e);

            }
            finally
            {
                conexionMaestra.cerrar();

            }
            return null;
        }


    }
}
