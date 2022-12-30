using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.Windows.Forms;

namespace ProyectoCliente.Datos
{
    public class Socket_Cliente
    {
        IPHostEntry host;
        IPAddress ipAddress;
        IPEndPoint endPoint;
        Socket s_Cliente;

        public Socket_Cliente(string ip, int puerto)
        {

            host = Dns.GetHostEntry(ip);

            ipAddress = host.AddressList[0];

            endPoint = new IPEndPoint(ipAddress, puerto);

            s_Cliente = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

          
        }

        //metodo para enviar el mensaje
        public void Start()
        {
            s_Cliente.Connect(endPoint);
        }

        public void Send(string mensaje)
        {
            byte[] byteMensaje = Encoding.ASCII.GetBytes(mensaje); 
            
            s_Cliente.Send(byteMensaje);

            //MessageBox.Show("Mensaje Enviado");
            

        }
        //metodo para recibir la respuesta
        public string Receive()
        {

            byte[] buffer = new byte[1024];

            s_Cliente.Receive(buffer);

            string ret = Encoding.ASCII.GetString(buffer);  

            return ret ;
        }


    }
}
