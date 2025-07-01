using BUS;
using DTO;
using MySqlX.XDevAPI.Common;
using System.Net;
using System.Net.Sockets;

class Program 
{
    private static void Main(string[] args)
    {
            BUS_query query = new BUS_query();
            Console.Title = "Tcp Server";
            var listener = new Socket(SocketType.Stream, ProtocolType.Tcp);
            listener.Bind(new IPEndPoint(IPAddress.Any, 5150));
            listener.Listen();
            Console.WriteLine($"Server started at {listener.LocalEndPoint}");

            while (true)
            {   
                var worker = listener.Accept();
                var stream = new NetworkStream(worker);
                var reader = new StreamReader(stream);
                var writer = new StreamWriter(stream) { AutoFlush = true };
                var request = reader.ReadLine();
             

            foreach (char c in request) 
            {
               if(c == '@')
                {  try
                    {
                        string data = request.Trim('@');
                        Console.WriteLine($"Client tim kiem :{data}");
                        string id = query.Timkiem(data).Rows[0]["id"].ToString();
                        string ten = query.Timkiem(data).Rows[0]["Tentu"].ToString();
                        string nghia = query.Timkiem(data).Rows[0]["Ynghia"].ToString();
                        List<string> list = new List<string> { id, ten, nghia };
                        string chuoi = string.Join(",", list);
                        writer.WriteLine(chuoi);
                        Console.WriteLine(">>>Server response  : " + chuoi);
                    }
                    catch (Exception ex) { }
                }
                else if (c == '!')
                {
                    string data = request.Trim('!');
                    string[] strings = data.Split(',');
                    int id = int.Parse(strings[0]);
                    Console.WriteLine("Client Dong gop : "+ strings[2]);
                    try
                    {
                        query.Sua(id, strings[1], strings[2]);
                        writer.WriteLine("Dong gop cua ban da duoc ghi nhan");
                        Console.WriteLine(">>>Server Response : Update successfull");
                    }catch(Exception e)
                    {
                        writer.WriteLine("Cam on dong gop cua ban");
                        Console.WriteLine(">>>Server response : No update");
                    }

                }
               else if(c == '#')
                {
                    string data = string.Join(',', query.danhsach(request.Trim('#')));
                    Console.WriteLine("Client nhap tu dien : " + request.Trim('#'));
                    writer.WriteLine(data);
                    Console.WriteLine(">>>Server response : "+ data);
                }
                }
               
                worker.Close();

            }
        }
    }