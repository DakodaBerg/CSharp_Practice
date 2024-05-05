using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Unit Testing
// Arrange, Act, Assert
// expected and actual = key names

// TDD - Test Driven Development 
// Write our test first before we write our code

// Red Green Refactor


namespace DemoLibrary.Tests
{
    public class DisplayMessagesTests
    {
        [Fact]
        public void GreetingShouldReturnGoodMorningMessage()
        {
            // Arrange
            DisplayMessages messages = new DisplayMessages();
            string expected = "Go to bed Dakoda";

            // Act
            string actual = messages.Greeting("Dakoda", 2);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GreetingShouldReturnGoodAfternoonMessage()
        {
            // Arrange
            DisplayMessages messages = new DisplayMessages();
            string expected = "Good afternoon Dakoda";

            // Act
            string actual = messages.Greeting("Dakoda", 14);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("Dakoda", 0, "Go to bed Dakoda")]
        [InlineData("Dakoda", 1, "Go to bed Dakoda")]
        [InlineData("Dakoda", 2, "Go to bed Dakoda")]
        [InlineData("Dakoda", 3, "Go to bed Dakoda")]
        [InlineData("Dakoda", 4, "Go to bed Dakoda")]
        [InlineData("Dakoda", 5, "Good morning Dakoda")]
        [InlineData("Dakoda", 6, "Good morning Dakoda")]
        [InlineData("Dakoda", 7, "Good morning Dakoda")]
        [InlineData("Dakoda", 8, "Good morning Dakoda")]
        [InlineData("Dakoda", 9, "Good morning Dakoda")]
        [InlineData("Dakoda", 10, "Good morning Dakoda")]
        [InlineData("Dakoda", 11, "Good morning Dakoda")]
        [InlineData("Dakoda", 12, "Good afternoon Dakoda")]
        [InlineData("Dakoda", 13, "Good afternoon Dakoda")]
        [InlineData("Dakoda", 14, "Good afternoon Dakoda")]
        [InlineData("Dakoda", 15, "Good afternoon Dakoda")]
        [InlineData("Dakoda", 16, "Good afternoon Dakoda")]
        [InlineData("Dakoda", 17, "Good afternoon Dakoda")]
        [InlineData("Dakoda", 18, "Good evening Dakoda")]
        [InlineData("Dakoda", 19, "Good evening Dakoda")]
        [InlineData("Dakoda", 20, "Good evening Dakoda")]
        [InlineData("Dakoda", 21, "Good evening Dakoda")]
        [InlineData("Dakoda", 22, "Good evening Dakoda")]
        [InlineData("Dakoda", 23, "Good evening Dakoda")]
        [InlineData("Dakoda", 24, "Good evening Dakoda")]
        public void GreetingShouldReturnExpectedValue(
            string firstName,
            int hourOfTheDay,
            string expected)
        {
            // Arrange
            DisplayMessages messages = new DisplayMessages();

            // Act
            string actual = messages.Greeting(firstName, hourOfTheDay);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
