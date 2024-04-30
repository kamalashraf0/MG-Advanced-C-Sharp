namespace MG_LINQ
{
    public class Department
    {

        public int ID { get; set; }

        public string Name { get; set; }


        public override string ToString()
        {
            return string.Format(
                $"" +
                $"{ID}" +
                $"{Name}"
                );
        }
    }
}
