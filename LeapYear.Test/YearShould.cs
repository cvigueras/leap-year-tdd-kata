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

        [Test]
        public void return_true_if_is_divisible_by_100_not_divisible_by_400()
        {
            var result = Year.IsLeapYear(1700);

            result.Should().Be(true);
        }

        [Test]
        public void return_true_if_is_divisible_by_100_not_divisible_by_400_other_number()
        {
            var result = Year.IsLeapYear(1800);

            result.Should().Be(true);
        }

        [Test]
        public void return_true_if_is_divisible_by_100_not_divisible_by_400_other_number_more()
        {
            var result = Year.IsLeapYear(1900);

            result.Should().Be(true);
        }
    }
}