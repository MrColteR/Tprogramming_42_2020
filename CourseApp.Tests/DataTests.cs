using System;
using Xunit;

namespace CourseApp.Tests
{
    public class DataTests
    {
        [Fact]
        public void DataAfter()
        {
            DateTime a = new DateTime(2020, 12, 12);
            DateTime b = new DateTime(2020, 12, 13);
            var actualResult = Program.Date(a, b);
            Assert.Equal("years = 0, months = 0, days = 1", actualResult);
        }

        [Fact]
        public void Data1996()
        {
            DateTime a = new DateTime(1996, 12, 12);
            DateTime b = new DateTime(2020, 12, 13);
            var actualResult = Program.Date(a, b);
            Assert.Equal("years = 24, months = 0, days = 1", actualResult);
        }

        [Fact]
        public void Data2010()
        {
            DateTime a = new DateTime(2010, 12, 12);
            DateTime b = new DateTime(2020, 12, 13);
            var actualResult = Program.Date(a, b);
            Assert.Equal("years = 10, months = 0, days = 1", actualResult);
        }

        [Fact]
        public void DataQuals()
        {
            DateTime a = new DateTime(2020, 12, 12);
            DateTime b = new DateTime(2020, 12, 12);
            var actualResult = Program.Date(a, b);
            Assert.Equal("years = 0, months = 0, days = 0", actualResult);
        }

        [Fact]
        public void DataBefore()
        {
            DateTime a = new DateTime(2020, 12, 12);
            DateTime b = new DateTime(2020, 12, 11);
            var actualResult = Program.Date(a, b);
            Assert.Equal("years = 0, months = 0, days = -1", actualResult);
        }
    }
}