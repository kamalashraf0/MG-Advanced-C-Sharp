using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;

namespace ADO_.NET.ORMs.Dapper.Executions
{
    public class MultipleQuery
    {
        public static void Print()
        {
            //Configure the connection from json file
            var configuration = new ConfigurationBuilder().
                AddJsonFile("appsettings.json").
                Build();




            //get connection to the string in json file 
            IDbConnection db = new SqlConnection(configuration.GetSection("ConnectionStrings").Value);


            //Query to execute
            var sql = "Select max(E_salary) from EmpModel;" +
                "Select min(E_Salary) from EmpModel; ";

            var Multiple = db.QueryMultiple(sql);

            Console.WriteLine($"Max Salary = {Multiple.ReadSingle<decimal>()}" +
                $"Min Salary = {Multiple.ReadSingle<decimal>()}");


        }
    }
}
