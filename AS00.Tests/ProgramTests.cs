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
            

            output = Program.IsLeapYear(2000);
     
            Assert.True(output);
        }

        [Fact]
        public void prints_nay()
        {   
            // Arrange
            var writer = new StringWriter();
            Console.SetOut(writer);

            var input = new StringReader("2001");
            Console.SetIn(input);

            //Act
            Program.UserInputIsLeapYear();
            
            
            //Assert
            var output = writer.GetStringBuilder().ToString().Trim();
            
            Assert.Equal("nay", output);
        }

        [Fact]
        public void prints_The_year_has_to_be_1582_or_bigger()
        {   
            // Arrange
            var writer = new StringWriter();
            Console.SetOut(writer);

            var input = new StringReader("1");
            Console.SetIn(input);

            //Act
            Program.UserInputIsLeapYear();
            
            
            //Assert
            var output = writer.GetStringBuilder().ToString().Trim();
            
            Assert.Equal("The year has to be 1582 or bigger", output);
        }
    }
}
