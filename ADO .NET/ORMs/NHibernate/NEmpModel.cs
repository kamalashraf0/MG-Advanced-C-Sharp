namespace ADO_.NET.Entities
{
    public class NEmpModel
    {
        public virtual int E_ID { get; set; }

        public virtual string E_Name { get; set; }

        public virtual int? E_Age { get; set; }

        public virtual decimal? E_Salary { get; set; }
        public virtual string? E_City { get; set; }

        public virtual string? MedicalInsurance { get; set; }

        public virtual int? D_ID { get; set; }


        public override string ToString()
        {
            return string.Format(
                "ID: {0,-5} Name: {1,-20} Age: {2,-5} Salary: {3,-10}   " +
                " City: {4,-15}  {5}  MedicalInsurance      DepartmentID : {6} ",
                E_ID,
                E_Name,
                E_Age,
                E_Salary?.ToString("C") ?? "0.00",
                E_City ?? "N/A", // 
                MedicalInsurance ?? "N/A",
                D_ID ?? 0
                );
        }
    }
}
