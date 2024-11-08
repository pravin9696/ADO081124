using System.Data;
using System.Data.SqlClient;


namespace ADO081124
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //connect to database useing SqlConnection class
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=abcd;Integrated Security=True;TrustServerCertificate=True");
            con.Open();

            //create object of SqlCommand class

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con; //step1
            cmd.CommandText = "select * from tblStudent"; // step2
            cmd.CommandType = CommandType.Text;  //step3

          SqlDataReader rdr= cmd.ExecuteReader();
            
            while(rdr.Read())
            {
                int roll = (int)rdr[0];
                string name = rdr[1].ToString();
                int contact = (int)rdr[2];
                Console.WriteLine($"Roll:{roll} Name: {name} Contact:{contact}");
            }
            con.Close();
        }
    }
}
