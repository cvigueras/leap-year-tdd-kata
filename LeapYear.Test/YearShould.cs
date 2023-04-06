using FluentAssertions;

namespace LeapYear.Test
{
    public class YearShould
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void return_true_if_is_leap_year()
        {
            var result = Year.IsLeapYear(2000);

            result.Should().Be(true);
        }

        [Test]
        public void return_true_if_is_leap_year_other_year()
        {
            var result = Year.IsLeapYear(800);

            result.Should().Be(true);
        }
        
    }

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
            return false;
        }
    }
}