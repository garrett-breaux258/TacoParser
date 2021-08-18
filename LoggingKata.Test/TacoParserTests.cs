using System;
using System.IO;
using System.Linq;
using GeoCoordinatePortable;
using Xunit;

namespace LoggingKata.Test
{
    public class TacoParserTests
    {
        [Fact]
        public void ShouldDoSomething()
        {

            
            var tacoParser = new TacoParser();

     
            var actual = tacoParser.Parse("34.073638, -84.677017, Taco Bell Acwort...");

           
            Assert.NotNull(actual);

        }

        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", -84.677017)]
        [InlineData("30.903723,-84.556037,Taco Bell Bainbridg...", -84.556037)]
        public void ShouldParseLongitude(string line, double expected)
        {
          
            var tester = new TacoParser();

            
            var actual = tester.Parse(line);

            
            Assert.Equal(expected, actual.Location.Longitude);
        }


       
        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", 34.073638)]
        public void ShouldParseLatitude(string line, double expected)
        {
            var test = new TacoParser();
            var actual = test.Parse(line);
            Assert.Equal(expected, actual.Location.Latitude);
        }


    }
}
