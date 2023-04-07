using FluentAssertions;
using LeapYear.Console;

namespace LeapYear.Test
{
    public class YearShould
    {
        Year _year;

        [SetUp]
        public void Setup()
        {
            _year = new Year();
        }

        [TestCase(0)]
        [TestCase(-1)]
        [TestCase(-20)]
        public void return_false_if_year_is_0_or_less_than_zero(int year)
        {
            var result = _year.IsLeapYear(year);

            result.Should().Be(false);
        }

        [TestCase(2000)]
        [TestCase(800)]
        [TestCase(400)]
        public void return_true_if_is_leap_year_divisible_by_400(int year)
        {
            var result = _year.IsLeapYear(year);

            result.Should().Be(true);
        }

        [TestCase(1700)]
        [TestCase(1800)]
        [TestCase(1900)]
        public void return_false_if_is_divisible_by_100_not_divisible_by_400(int year)
        {
            var result = _year.IsLeapYear(year);

            result.Should().Be(false);
        }

        [TestCase(2008)]
        [TestCase(2012)]
        [TestCase(2016)]
        public void return_true_if_is_divisible_by_4_not_divisible_by_100(int year)
        {
            var result = _year.IsLeapYear(year);

            result.Should().Be(true);
        }

        [TestCase(2017)]
        [TestCase(2018)]
        [TestCase(2019)]
        public void return_false_if_is_not_divisible_by_4(int year)
        {
            var result = _year.IsLeapYear(year);

            result.Should().Be(false);
        }
    }
}