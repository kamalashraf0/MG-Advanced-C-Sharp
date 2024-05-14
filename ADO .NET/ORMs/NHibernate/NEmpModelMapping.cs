using ADO_.NET.Entities;
using NHibernate;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;

namespace ADO_.NET.ORMs.NHibernate
{
    public class NEmpModelMapping : ClassMapping<NEmpModel>
    {
        public NEmpModelMapping()
        {

            Id(x => x.E_ID,
                c =>
                {
                    c.Generator(Generators.Identity);
                    c.Type(NHibernateUtil.Int32);
                    c.Column("E_ID");
                    c.UnsavedValue(0);

                }
                );

            Property(x => x.E_Name,
                c =>
                {
                    c.Length(20);
                    c.Type(NHibernateUtil.AnsiString);
                    c.NotNullable(true);



                });

            Property(x => x.E_Salary,
               c =>
               {

                   c.Type(NHibernateUtil.Decimal);
                   c.NotNullable(true);



               });

            Table("EmpModel");


        }
    }
}
