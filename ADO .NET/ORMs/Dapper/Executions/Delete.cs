using ADO_.NET.Entities;
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;

namespace ADO_.NET.ORMs.Dapper.Executions
{
    public class Delete
    {
        public static void Print()
        {
            //Configure the connection from json file
            var configuration = new ConfigurationBuilder().
                AddJsonFile("appsettings.json").
                Build();




            //get connection to the string in json file 
            IDbConnection db = new SqlConnection(configuration.GetSection("ConnectionStrings").Value);

            var employee = new EmpModel
            {
                E_ID = 17,
            };


            //Query to execute
            var sql = "Delete From EmpModel where E_ID = @id ";

            var parameters = new
            {
                id = employee.E_ID
            };

            db.Execute(sql, parameters);
        }
    }
}
