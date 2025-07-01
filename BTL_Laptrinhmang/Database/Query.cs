using MySql.Data.MySqlClient;
using System.Data;
namespace DAL
{

    public class Query : ConnectDB
    {
        public bool Them(string tu,string yNghia)
        {
            con.Open();
            string query = $"INSERT INTO tracuu(Tentu,Ynghia) VALUE(\"{tu}\",\"{yNghia}\")";
            MySqlCommand cmd = new MySqlCommand(query, con);
            if (cmd.ExecuteNonQuery() > 0)
            {
                con.Close();
                return true;
            }
            con.Close();
            return false;

        }

        public DataTable hienThi()
        {
            con.Open();
            string query = "SELECT * FROM tracuu";
            MySqlDataAdapter dap= new MySqlDataAdapter(query, con);
            MySqlCommandBuilder cmb = new MySqlCommandBuilder(dap);
            DataTable dt = new DataTable();
            dap.Fill(dt);
            con.Close();
            return dt;
        }
        public bool sua(int id,string tu,string ynghia) 
        {
            con.Open();
            string query = $"UPDATE tracuu SET Tentu =\"{tu}\",Ynghia =\"{ynghia}\" WHERE id ={id}";
            MySqlCommand cmd = new MySqlCommand(query , con);
            if (cmd.ExecuteNonQuery() > 0)
            {
                con.Close();
                return true;
            }
             con.Close();
            return false;
            
        }
        public bool xoa(int id)
        {
            con.Open() ;
            string query = $"DELETE FROM tracuu WHERE id ={id}";
            MySqlCommand cmd = new MySqlCommand( query , con);
            if (cmd.ExecuteNonQuery() > 0)
            {
                con.Close();
                return true;
            }
            con.Close();
            return false;
        }
        public List<string> Danhsach(string timkiem)
        {
            con.Open();
            string query = $"SELECT Tentu FROM tracuu WHERE Tentu LIKE \"%{timkiem}\"" +
                $" OR Tentu LIKE \"%{timkiem}%\" OR Tentu LIKE \"{timkiem}%\" OR Tentu =\"{timkiem}\" " ;
            MySqlDataAdapter dap = new MySqlDataAdapter(query, con);
            MySqlCommandBuilder cmb = new MySqlCommandBuilder(dap);
            DataTable dt = new DataTable();
            dap .Fill(dt);
            con.Close();
            List<string> list = new List<string>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                list.Add(dt.Rows[i]["Tentu"].ToString());
            }
            return list;
        }
        public DataTable Timkiem(string timkiem) 
        {
            con.Open();
            string query = $"SELECT * FROM tracuu WHERE Tentu =\"{timkiem}\" ";
            MySqlDataAdapter dap = new MySqlDataAdapter(query, con);
            MySqlCommandBuilder cmb = new MySqlCommandBuilder(dap);
            DataTable dt = new DataTable();
            dap.Fill(dt);
            con.Close();
            return dt;
        }
    }
}

