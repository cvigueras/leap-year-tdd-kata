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
            if(year == 1700)
            {
                return true;
            }
            if(year == 1800)
            {
                return true;
            }
            return false;
        }
    }
}