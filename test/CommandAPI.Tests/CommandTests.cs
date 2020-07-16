using System;
using Xunit;
using CommandAPI.Models;

namespace CommandAPI.Tests
{
    public class CommandTests : IDisposable
    {
        Command testCommand;

        public CommandTests()
        {
            // Arrange
            testCommand = new Command
            {
                HowTo = "Do something great",
                Platform = "xUnit",
                CommandLine = "dotnet test"
            };
        }

        public void Dispose()
        {
            testCommand = null;
        }

        [Fact]
        public void CanChangeHowTo()
        {
            // Act
            testCommand.HowTo = "Execute unit tests";

            // Assert
            Assert.Equal("Execute unit tests", testCommand.HowTo);
        }

        [Fact]
        public void CanChangePlatform()
        {
            // Act
            testCommand.Platform = "New platform";

            // Assert
            Assert.Equal("New platform", testCommand.Platform);
        }

        [Fact]
        public void CanChangeCommandLine()
        {
            // Act
            testCommand.CommandLine = "new command line text";

            // Assert
            Assert.Equal("new command line text", testCommand.CommandLine);
        }

        
    }
}