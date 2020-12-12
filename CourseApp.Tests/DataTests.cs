using System;
using Xunit;

namespace CourseApp.Tests
{
    public class DataTests
    {
        [Fact]
        public void DataAfter()
        {
            DateTime a = new DateTime(20, 12, 12);
            DateTime b = new DateTime(20, 12, 13);
            var actualResult = Program.Date(a, b);
            Assert.Equal("years = 0, months = 0, days = 1", actualResult);
        }

        [Fact]
        public void DataQuals()
        {
            DateTime a = new DateTime(20, 12, 12);
            DateTime b = new DateTime(20, 12, 12);
            var actualResult = Program.Date(a, b);
            Assert.Equal("years = 0, months = 0, days = 0", actualResult);
        }

        [Fact]
        public void DataBefore()
        {
            DateTime a = new DateTime(20, 12, 12);
            DateTime b = new DateTime(20, 12, 11);
            var actualResult = Program.Date(a, b);
            Assert.Equal("years = 0, months = 0, days = -1", actualResult);
        }
    }
}