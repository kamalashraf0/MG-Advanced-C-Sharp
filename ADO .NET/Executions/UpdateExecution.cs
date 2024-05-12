using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;

namespace ADO_.NET.Executions
{
    static public class UpdateExecution
    {
        public static void Print()
        {
            // Configure the connection from json file
            var configuration = new ConfigurationBuilder().
                AddJsonFile("appsettings.json").
                Build();


            //read from user input

            //var insertemployee = new EmpModel
            //{
            //    E_ID = 17,
            //    E_Name = "Madeha"
            //};

            //get connection to the string in json file 
            var connection = new SqlConnection(configuration.GetSection("ConnectionStrings").Value);



            var sql = $"Update Empmodel set E_name =@name where E_id = 17";




            SqlParameter idparameter = new SqlParameter
            {
                ParameterName = "@id",
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Input,
                Value = 17,


            };

            SqlParameter nameparameter = new SqlParameter
            {
                ParameterName = "@name",
                SqlDbType = SqlDbType.VarChar,
                Direction = ParameterDirection.Input,
                Value = "Abdelshafy",


            };



            //command for the execution based on the connection
            SqlCommand cmd = new SqlCommand(sql, connection);

            cmd.Parameters.Add(idparameter);
            cmd.Parameters.Add(nameparameter);

            cmd.CommandType = CommandType.Text;

            connection.Open();



            if (cmd.ExecuteNonQuery() > 0)
            {
                Console.WriteLine($"Welcome New Commer ");
            }
            else
            {
                Console.WriteLine("Try Again");
            }

            connection.Close();
        }
    }
}
