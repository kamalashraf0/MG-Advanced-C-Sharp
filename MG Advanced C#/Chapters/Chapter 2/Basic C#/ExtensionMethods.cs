namespace MG_Advanced_C_.Basic_C_
{
    public static class ExtensionMethods
    {

        public static bool isWeekend(this DateTime value) //this keyword to the object of t
        {
            return value.DayOfWeek == DayOfWeek.Friday;
        }
    }
}
