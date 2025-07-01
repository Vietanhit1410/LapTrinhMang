using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DAL
{
    public class ConnectDB
    {
      protected  MySqlConnection con = new MySqlConnection("Server=localhost; Database=tudien; port=3306;" +
                                                  "User ID= root; password =14102004");
    }
}
