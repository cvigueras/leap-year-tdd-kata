namespace LeapYear.Console
{
    public class Year
    {
        public static bool IsLeapYear(int year)
        {
            if(year % 400 == 0)
            {
                return true;
            }
            return false;
        }
    }
}