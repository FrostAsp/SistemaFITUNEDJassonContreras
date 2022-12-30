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
    public class DsedesClientes
    {
        //conexion maestra para abrir y cerrar conexiones
        CONEXIONMAESTRA conexionMaestra;

        public DsedesClientes(CONEXIONMAESTRA conexionMaestra)
        {

            this.conexionMaestra = conexionMaestra;  

        }
        //traer los datos de las tablas clientes y sede para mostrarlos en los datagrivie
        public void mostrarSedesClientes(ref DataTable dt, ref DataTable tb)
        {
            string consultaClientes = "SELECT IdCliente, Nombre, PrimerApellido, SegundoApellido FROM Cliente";

            string consultaSedes = "SELECT IdSede, Nombre, Estado FROM Sede where Estado = 1";

            try
            {

                conexionMaestra.abrir();
                SqlDataAdapter cmdClientes = new SqlDataAdapter(consultaClientes, conexionMaestra.conectar);
                SqlDataAdapter cmdSedes = new SqlDataAdapter(consultaSedes, conexionMaestra.conectar);

                cmdClientes.Fill(dt);
                cmdSedes.Fill(tb);


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

        //mostrar id clientesen el combobox
        public void mostrarIDClientesDisponibles(ComboBox idclientes)
        {
            string consulta = "SELECT IdCliente FROM Cliente";

            try
            {

                conexionMaestra.abrir();
                SqlCommand cmd = new SqlCommand(consulta, conexionMaestra.conectar);

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    idclientes.Items.Add(dr.GetString(0));
                }
              

            }
            catch (Exception e)
            {

                MessageBox.Show("Error al ingresar datos al combobox por error : "+ e.ToString());

            }
            finally
            {
                conexionMaestra.cerrar();

            }

        }

        // mostrar id sedes el comobobox
        public void mostrarIDSedesDisponibles(ComboBox idSedes)
        {
            string consulta = "SELECT IdSede FROM Sede where Estado = 1";
            
            try
            {

                conexionMaestra.abrir();
                SqlCommand cmd = new SqlCommand(consulta, conexionMaestra.conectar);

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {                   
                    
                    idSedes.Items.Add(dr.GetInt32(0));                 
                }
            }
            catch (Exception e)
            {

                MessageBox.Show("Error al ingresar datos al combobox por error : "+ e.ToString());

            }
            finally
            {
                conexionMaestra.cerrar();

            }

        }

        public void afiliacionSedeCliente(AfiliacionClienteSede dato)
        {
            
            string consulta = "INSERT INTO AfiliacionSede (IdAfiliacion, FechaAfiliacion, IdCliente, IdSede)" +
                " values('"+dato.IdAfiliacion+"','"+dato.FechaAfiliacion.Date.ToString("yyyyMMdd")+"', '"+dato.IdCliente+"','"+dato.IdSede +"')";
            try
            {

                conexionMaestra.abrir();
                SqlCommand cmd = new SqlCommand(consulta, conexionMaestra.conectar);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Afiliacion Agregada con exito");

            }
            catch (Exception e)
            {

                MessageBox.Show("Error al ingresar datos al combobox por error : "+ e.ToString());

            }
            finally
            {
                conexionMaestra.cerrar();

            }

        }

        public void mostrarAfiliacionClientes(ref DataTable dt)
        {

            string consultaClientes = "SELECT a.IdAfiliacion, a.FechaAfiliacion, c.IdCliente, c.Nombre, c.PrimerApellido, c.SegundoApellido, c.FechaNacimiento, c.Genero FROM AfiliacionSede a INNER JOIN Cliente c ON a.IdCliente = c.IdCliente";

            try
            {

                conexionMaestra.abrir();
                SqlDataAdapter cmdClientes = new SqlDataAdapter(consultaClientes, conexionMaestra.conectar);
               
                cmdClientes.Fill(dt);
               


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

        public void mostrarAfiliacionSedes(ref DataTable dt)
        {

            string consultaClientes = "SELECT a.IdAfiliacion, a.IdSede,c.Nombre, c.Direccion, c.Estado, c.Telefono FROM AfiliacionSede a INNER JOIN Sede c ON a.IdSede = c.IdSede";

            try
            {

                conexionMaestra.abrir();
                SqlDataAdapter cmdClientes = new SqlDataAdapter(consultaClientes, conexionMaestra.conectar);

                cmdClientes.Fill(dt);



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
