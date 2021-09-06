using System;
using System.IO;
using Xunit;

namespace AS00.Tests
{
    public class ProgramTests
    {
        [Fact]
        public void Main_prints_Hello_World()
        {   
            // Arrange
            var writer = new StringWriter();
            Console.SetOut(writer);

            //Act
            Program.Main(new string[0]);

            //Assert
            var output = writer.GetStringBuilder().ToString().Trim();
            Assert.Equal("Hello World!", output);
        }

        [Fact]
        public void is_it_a_leapYear(){
    
            //Assert
            var output = false;
            var program = new Program();

            output = program.IsLeapYear(2000);
     
            Assert.True(output);
        }
    }
}
