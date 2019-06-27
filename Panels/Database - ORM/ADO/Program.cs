using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO
{
    class Program
    {
        //
        // Criando uma classe com SqlClient (ADO)
        // 
        // var con = new SqlConnection("connectionstring...");
        //
        // con.Open();
        //
        // var comando = new SqlCommand ("select..", con);
        //
        // var dr = new cmd.ExecuteReader();
        //
        // while (dr.Read())
        // { 
        //   Console.Writeline(dr[0]) 
        // };
        //


        static void Main(string[] args)
        {
            var lista = new List<string>();

            var connectionString = "Data Source=DESKTOP-HEJ5712;Initial Catalog=Entity;Connection Timeout=180;Persist Security Info=True;User ID=sa;Password=123456";

            SqlConnection con = new SqlConnection(connectionString);

            con.Open();

            SqlCommand cmd = new SqlCommand("select * from tabela", con);

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Console.WriteLine($"Campo 1: {dr[0]}");
                Console.WriteLine($"Campo 2: {dr[1]}");
            }

            Console.ReadLine();

        }
    }
}



