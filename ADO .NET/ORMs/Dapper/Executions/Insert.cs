using ADO_.NET.Entities;
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;

namespace ADO_.NET.ORMs.Dapper.Executions
{
    public class Insert
    {
        public static void Print()
        {
            //Configure the connection from json file
            var configuration = new ConfigurationBuilder().
                AddJsonFile("appsettings.json").
                Build();




            //get connection to the string in json file 
            IDbConnection db = new SqlConnection(configuration.GetSection("ConnectionStrings").Value);


            var Employee = new EmpModel
            {
                E_ID = 17,
                E_Name = "Sanya",
                E_Salary = 15000m

            };

            //Query to execute
            var sql = "insert into EmpModel (E_ID ,E_Name,E_Salary)" +
                $" values (@id,@name,@salary)";

            //parameters
            var DapperINsert = db.Execute(sql, new
            {
                id = Employee.E_ID,
                name = Employee.E_Name
                ,
                salary = Employee.E_Salary
            });




        }
    }
}
