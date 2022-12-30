using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaFITUNEDJassonContreras.Datos
{
    public class Socket_Servidor
    {

        IPHostEntry host;
        IPAddress ipAddress;
        IPEndPoint endPoint;

        Socket s_Servidor;
        Socket s_Cliente;

        ConsultaLogin consultas ;

        ConsultaLogin consultaLogin;

        public Socket_Servidor(string ip, int puerto, ConsultaLogin consultaLogin)
        {

            host = Dns.GetHostEntry(ip);
            ipAddress = host.AddressList[0];
            endPoint = new IPEndPoint(ipAddress, puerto);
            s_Servidor = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            s_Servidor.Bind(endPoint);
            s_Servidor.Listen(5);

            this.consultaLogin = consultaLogin;

        }

        //metodo star del servidor
        public void Start()
        {
                Thread hilo_servidor;

                s_Cliente = s_Servidor.Accept();
                hilo_servidor = new Thread(clienteConexion);
                hilo_servidor.Start();
            
                 
        }

        public void clienteConexion()
        {

            byte[] buffer;
            string identificador;

            int finalCadena;

            while (true)
            {
                buffer = new byte[1024];

                s_Cliente.Receive(buffer);

                identificador = Encoding.ASCII.GetString(buffer);

                //MessageBox.Show("Se recibio el mensaje" + identificador);

                if (identificador=="1") 
                {

                    consultaLogin.abrirConexion();

                    byte[] respuesta = Encoding.ASCII.GetBytes("Conexion Exitosa");
                    
                    s_Cliente.Send(respuesta);

                }

                //if (consultaLogin.login_cliente(identificador))
                //{
                //    consultaLogin.abrirConexion();
                //    byte[] respuesta = Encoding.ASCII.GetBytes("Cliente Registrado");

                //    s_Cliente.Send(respuesta);

                //}
                //else
                //{
                //    consultaLogin.abrirConexion();
                //    byte[] respuesta = Encoding.ASCII.GetBytes("Cliente No Registrado");

                //    s_Cliente.Send(respuesta);

                //}    

            }
            

        }

        public void escribirMsj(string mensaje)
        {

            try
            {



            }
            catch (Exception)
            {

                throw;
            }




        }

        public void enviarPaquete(Paquete paquete)
        {



        }



        public void validarID(string identificador)
        {



        }

    }
}
