using System;
using LessPaper.WriteService.Controllers;
using Xunit;

namespace LessPaper.WriteService.UnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var e = new WeatherForecastController(null).Get();
        }
    }
}
