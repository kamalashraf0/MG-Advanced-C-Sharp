using ADO_.NET.Entities;
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;

namespace ADO_.NET.ORMs.Dapper.Executions
{
    public class SelectBinding
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
            var sql = "Select * from EmpModel";

            Console.WriteLine("*********************************** using dynamic Query");

            var resultAsdynamic = db.Query(sql);

            foreach (var item in resultAsdynamic)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("*********************************** using typed Query");


            var resultAsTyped = db.Query<EmpModel>(sql);

            foreach (var item in resultAsTyped)
            {
                Console.WriteLine(item);
            }
        }
    }
}
