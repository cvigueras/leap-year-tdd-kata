using FluentAssertions;
using LeapYear.Console;

namespace LeapYear.Test
{
    public class YearShould
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(2000)]
        [TestCase(800)]
        [TestCase(400)]
        public void return_true_if_is_leap_year_divisible_by_400(int year)
        {
            var result = Year.IsLeapYear(year);

            result.Should().Be(true);
        }

        [TestCase(1700)]
        [TestCase(1800)]
        [TestCase(1900)]
        public void return_false_if_is_divisible_by_100_not_divisible_by_400(int year)
        {
            var result = Year.IsLeapYear(year);

            result.Should().Be(false);
        }

        [TestCase(2008)]
        [TestCase(2012)]
        [TestCase(2016)]
        public void return_true_if_is_divisible_by_4_not_divisible_by_100(int year)
        {
            var result = Year.IsLeapYear(year);

            result.Should().Be(true);
        }

        [Test]
        public void return_false_if_is_not_divisible_by_4()
        {
            var result = Year.IsLeapYear(2017);

            result.Should().Be(false);
        }
    }
}