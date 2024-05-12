using ADO_.NET.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;

namespace ADO_.NET.Executions
{
    static public class InsertExecution
    {
        public static void Print()
        {
            //Configure the connection from json file
            var configuration = new ConfigurationBuilder().
                AddJsonFile("appsettings.json").
                Build();


            //read from user input

            var insertemployee = new EmpModel
            {
                E_ID = 16,
                E_Name = "Ibrahim"
            };

            //get connection to the string in json file 
            var connection = new SqlConnection(configuration.GetSection("ConnectionStrings").Value);

            //Query to execute
            var sql = "insert into EmpModel (E_ID ,E_Name)" +
                $" values (@id,@name)";


            SqlParameter idparameter = new SqlParameter
            {
                ParameterName = "@id",
                SqlDbType = SqlDbType.VarChar,
                Direction = ParameterDirection.Input,
                Value = insertemployee.E_ID,


            };

            SqlParameter nameparameter = new SqlParameter
            {
                ParameterName = "@name",
                SqlDbType = SqlDbType.VarChar,
                Direction = ParameterDirection.Input,
                Value = insertemployee.E_Name,


            };



            //command for the execution based on the connection
            SqlCommand cmd = new SqlCommand(sql, connection);

            cmd.Parameters.Add(idparameter);
            cmd.Parameters.Add(nameparameter);

            cmd.CommandType = CommandType.Text;

            connection.Open();



            if (cmd.ExecuteNonQuery() > 0)
            {
                Console.WriteLine($"Welcome {insertemployee.E_Name}");
            }
            else
            {
                Console.WriteLine("Try Again");
            }

            connection.Close();









        }
    }
}
