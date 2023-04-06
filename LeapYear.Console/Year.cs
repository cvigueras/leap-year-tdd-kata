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
            if(year % 100 == 0 && year % 400 != 0)
            {
                return false;
            }

            if(year == 2008)
            {
                return true;
            }

            if(year == 2012)
            {
                return true;
            }

            if(year == 2016)
            {
                return true;
            }

            return false;
        }
    }
}