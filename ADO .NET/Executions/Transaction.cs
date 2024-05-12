using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;

namespace ADO_.NET.Executions
{
    static public class Transaction
    {
        public static void Print()
        {
            //Configure the connection from json file
            var configuration = new ConfigurationBuilder().
                AddJsonFile("appsettings.json").
                Build();

            //get connection to the string in json file 
            var connection = new SqlConnection(configuration.GetSection("ConnectionStrings").Value);

            //command for the execution based on the connection
            SqlCommand cmd = connection.CreateCommand();

            cmd.CommandType = CommandType.Text;

            connection.Open();

            SqlTransaction trans = connection.BeginTransaction();

            cmd.Transaction = trans;

            try
            {
                cmd.CommandText = " Update EmpModel set E_name = 'AboTreka' where E_ID = 15 ";
                cmd.ExecuteNonQuery();

                cmd.CommandText = " insert into EmpModel (E_ID ,E_Name) values (16 , 'Nani') ";
                cmd.ExecuteNonQuery();

                trans.Commit();

                Console.WriteLine("Successfully");
            }
            catch
            {
                trans.Rollback();
                Console.WriteLine("Try Again");
            }




            connection.Close();
        }
    }
}
