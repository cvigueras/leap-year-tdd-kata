namespace LeapYear.Console
{
    public class Year
    {
        public bool IsLeapYear(int year)
        {
            return year > 0 
                && (year % 400 == 0 || year % 4 == 0 
                && year % 100 > 0);
        }
    }
}