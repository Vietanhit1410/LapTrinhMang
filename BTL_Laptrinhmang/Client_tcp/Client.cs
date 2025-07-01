using System.Net.Sockets;
using System.Net;
using System.Text;
using DTO;

namespace Client_tcp
{
    public class Client
    {
        public string client_request_TraTu(string request)
        {
            var ip = IPAddress.Parse("127.0.0.1");
            var port = 5150;
            IPEndPoint serverEndPoint = new IPEndPoint(ip, port);
            int a = 1;
            string result = "";
            while (a == 1)
            {
                try
                {
                    var client = new Socket(SocketType.Stream, ProtocolType.Tcp);
                    client.Connect(serverEndPoint);
                    // Khởi tạo biến network stream từ tcp socket
                    var stream = new NetworkStream(client);
                    var sendBuffer = Encoding.UTF8.GetBytes(request+'@' + "\r\n");
                    // ghi mảng byte vào stream thay vì send bằng socket
                    stream.Write(sendBuffer, 0, sendBuffer.Length);
                    stream.Flush();
                    var receiveBuffer = new byte[1024];
                    var count = stream.Read(receiveBuffer, 0, 1024);
                    var response = Encoding.UTF8.GetString(receiveBuffer, 0, count);
                    result = response.Trim();
                   
                    client.Close();
                    a = a + 1;
                }catch (Exception ex) {Console.WriteLine(ex);}
                
            }
            return result;
        }

        public string client_request_Gopy(List<string> request)
        {
            var ip = IPAddress.Parse("127.0.0.1");
            var port = 5150;
            IPEndPoint serverEndPoint = new IPEndPoint(ip, port);
            int a = 1;
            string result = "";
            while (a == 1)
            {
                try
                {
                    var client = new Socket(SocketType.Stream, ProtocolType.Tcp);
                    client.Connect(serverEndPoint);
                    // Khởi tạo biến network stream từ tcp socket
                    var stream = new NetworkStream(client);
                    string data = string.Join(',', request);
                    var sendBuffer = Encoding.UTF8.GetBytes(data + '!' + "\r\n");
                    // ghi mảng byte vào stream thay vì send bằng socket
                    stream.Write(sendBuffer, 0, sendBuffer.Length);
                    stream.Flush();
                    var receiveBuffer = new byte[1024];
                    var count = stream.Read(receiveBuffer, 0, 1024);
                    var response = Encoding.UTF8.GetString(receiveBuffer, 0, count);
                    result = response.Trim();
                    client.Close();
                    a = a + 1;
                }
                catch (Exception ex) { Console.WriteLine(ex); }

            }
            return result;
        }

        public string client_request_list(string danhsach)
        {
            var ip = IPAddress.Parse("127.0.0.1");
            var port = 5150;
            IPEndPoint serverEndPoint = new IPEndPoint(ip, port);
            int a = 1;
            string result = "";
            while (a == 1)
            {
                try
                {
                    var client = new Socket(SocketType.Stream, ProtocolType.Tcp);
                    client.Connect(serverEndPoint);
                    // Khởi tạo biến network stream từ tcp socket
                    var stream = new NetworkStream(client);
                    
                    var sendBuffer = Encoding.UTF8.GetBytes(danhsach+ '#' + "\r\n");
                    // ghi mảng byte vào stream thay vì send bằng socket
                    stream.Write(sendBuffer, 0, sendBuffer.Length);
                    stream.Flush();
                    var receiveBuffer = new byte[1024];
                    var count = stream.Read(receiveBuffer, 0, 1024);
                    var response = Encoding.UTF8.GetString(receiveBuffer, 0, count);
                    result = response.Trim();
                    client.Close();
                    a = a + 1;
                }
                catch (Exception ex) { Console.WriteLine(ex); }

            }
            return result;
        }
    }
}
