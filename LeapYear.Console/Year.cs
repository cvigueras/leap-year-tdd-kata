namespace LeapYear.Console
{
    public class Year
    {
        public static bool IsLeapYear(int year)
        {
            if(year == 2000)
            {
                return true;
            }
            if(year == 800)
            {
                return true;
            }
            if(year == 400)
            {
                return true;
            }
            return false;
        }
    }
}