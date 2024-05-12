using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;

namespace ADO_.NET.Executions
{
    static public class DeleteExecution
    {
        public static void Print()
        {
            // Configure the connection from json file
            var configuration = new ConfigurationBuilder().
                AddJsonFile("appsettings.json").
                Build();




            //get connection to the string in json file 
            var connection = new SqlConnection(configuration.GetSection("ConnectionStrings").Value);



            var sql = $"Delete from EmpModel where E_ID in ( @id, @id2)";




            SqlParameter idparameter = new SqlParameter
            {
                ParameterName = "@id",
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Input,
                Value = 16,


            };


            SqlParameter id2parameter = new SqlParameter
            {
                ParameterName = "@id2",
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Input,
                Value = 17,


            };




            //command for the execution based on the connection
            SqlCommand cmd = new SqlCommand(sql, connection);

            cmd.Parameters.Add(idparameter);
            cmd.Parameters.Add(id2parameter);

            cmd.CommandType = CommandType.Text;

            connection.Open();



            if (cmd.ExecuteNonQuery() > 0)
            {
                Console.WriteLine($"Deletion Succefully ");
            }
            else
            {
                Console.WriteLine("Try Again");
            }

            connection.Close();
        }
    }
}
