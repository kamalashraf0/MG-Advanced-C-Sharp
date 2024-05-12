using ADO_.NET.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Text;

namespace ADO_.NET.Executions
{
    static public class SelectExecution
    {
        public static void Print()
        {
            //Configure the connection from json file
            var configuration = new ConfigurationBuilder().
                AddJsonFile("appsettings.json").
                Build();

            //get connection to the string in json file 
            var connection = new SqlConnection(configuration.GetSection("ConnectionStrings").Value);

            //Query to execute
            var sql = "Select * from EmpModel";

            //command for the execution based on the connection
            SqlCommand cmd = new SqlCommand(sql, connection);

            cmd.CommandType = CommandType.Text;

            connection.Open();

            SqlDataReader reader = cmd.ExecuteReader();


            EmpModel employee;

            while (reader.Read())
            {



                employee = new EmpModel()
                {
                    E_ID = reader.GetInt32("E_ID"),
                    E_Name = reader.GetString("E_Name"),
                    //E_Age = reader.GetInt32("E_Age")
                    //E_Salary = reader.GetDecimal("E_salary") 
                    //E_City = reader.GetString("E_City"),
                    //MedicalInsurance = reader.GetString("MedicalInsurance"),


                };
                Console.WriteLine(employee);
            }

            connection.Close();

        }
    }
}
