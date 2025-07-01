
using System.Net;
using System.Net.Sockets;
using System.Text;
namespace Client
{
    public class Client_tcp
    {
        public string server_response()
        {
            var ip = IPAddress.Parse("127.0.0.1");
            var port = 5150;
            IPEndPoint serverEndPoint = new IPEndPoint(ip, port);
          
  
                var client = new Socket(SocketType.Stream, ProtocolType.Tcp);
                client.Connect(serverEndPoint);
                // Khởi tạo biến network stream từ tcp socket
                var stream = new NetworkStream(client);
                var receiveBuffer = new byte[1024];
                var count = stream.Read(receiveBuffer, 0, 1024);
                var response = Encoding.UTF8.GetString(receiveBuffer, 0, count);
                string responseString = response.Trim();
                client.Close();
                return responseString;

            
            
        }

        public void client_request(string request)
        {
            var ip = IPAddress.Parse("127.0.0.1");
            var port = 5150;
            IPEndPoint serverEndPoint = new IPEndPoint(ip, port);

                    var client = new Socket(SocketType.Stream, ProtocolType.Tcp);
                    client.Connect(serverEndPoint);
                    // Khởi tạo biến network stream từ tcp socket
                    var stream = new NetworkStream(client);
                    var sendBuffer = Encoding.UTF8.GetBytes(request +"\r\n");
                    // ghi mảng byte vào stream thay vì send bằng socket
                    stream.Write(sendBuffer, 0, sendBuffer.Length);
                    stream.Flush();
                    client.Close();
            

        }
    }
}