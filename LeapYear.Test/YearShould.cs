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
        
    }

    public class Year
    {
        public static bool IsLeapYear(int year)
        {
            throw new NotImplementedException();
        }
    }
}