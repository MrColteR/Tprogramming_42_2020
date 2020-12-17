using System;
using Xunit;

namespace CourseApp.Tests
{
    public class DataTests
    {
        [Theory]
        [InlineData(2002, 10, 31, 2020, 12, 16, "Возраст: 18 лет(год), 1 месяцев(месяц), 16 дней(день)")]
        [InlineData(2000, 12, 15, 2020, 12, 13, "Возраст: 19 лет(год), 11 месяцев(месяц), 29 дней(день)")]
        [InlineData(2021, 12, 15, 2020, 12, 15, "Не верный возвраст")]
        public void DateTest(int yearB, int monthB, int dayB, int yearT, int monthT, int dayT, string exp)
        {
            DateTime a = new DateTime(yearB, monthB, dayB);
            DateTime b = new DateTime(yearT, monthT, dayT);
            var actualResult = Program.Date(a, b);
            Assert.Equal(exp, actualResult);
        }
    }
}