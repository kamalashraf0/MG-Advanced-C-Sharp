using ADO_.NET.Entities;
using Microsoft.Extensions.Configuration;
using NHibernate;
using NHibernate.Cfg.MappingSchema;
using NHibernate.Dialect;
using NHibernate.Driver;
using NHibernate.Mapping.ByCode;
using Configuration = NHibernate.Cfg.Configuration;

namespace ADO_.NET.ORMs.NHibernate
{
    public class Session
    {
        public static void Print()
        {

            using (var session = CreateSession())
            {
                Console.WriteLine(session.IsConnected);
            }


        }

        private static ISession CreateSession()
        {
            //Configure the connection from json file
            var configuration = new ConfigurationBuilder().
                AddJsonFile("appsettings.json").
                Build();

            //get connection to the string in json file 
            var connection = configuration.GetSection("ConnectionStrings").Value;

            var mapper = new ModelMapper();

            //list of all type mappings from assembly

            mapper.AddMappings(typeof(NEmpModel).Assembly.ExportedTypes);

            //compile class mapping

            HbmMapping domainMapping = mapper.CompileMappingForAllExplicitlyAddedEntities();

            // allow  the application to specify properties and mapping documents
            // to be used when creating 

            var hiberConfig = new Configuration();

            //settings for app to nhibernate
            hiberConfig.DataBaseIntegration(x =>
            {
                //strategy to interact with provider 

                x.Driver<MicrosoftDataSqlClientDriver>();

                //dialect nhibernate uses to build syntax to RDBMS

                x.Dialect<MsSql2012Dialect>();

                //Connection string

                x.ConnectionString = connection;

                //log sql statement to console 

                x.LogSqlInConsole = true;


                //format logged sql statement 

                x.LogFormattedSql = true;





            });

            //add mapping to nhibernate configuration 
            hiberConfig.AddMapping(domainMapping);


            //instansiate a new IsessionFactory (use properties , settings and mapping)

            var sessionFactory = hiberConfig.BuildSessionFactory();

            var session = sessionFactory.OpenSession();

            return session;




        }
    }
}
