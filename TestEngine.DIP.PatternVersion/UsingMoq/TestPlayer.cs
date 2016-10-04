using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DIP.PatternVersion.Moq;
using Moq;

namespace TestEngine.DIP.PatternVersion.UsingMoq
{
    [TestClass]
    public class TestPlayer
    {
        // Should recieve an exception, since player name is an empty string.
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_CreateNewPlayer_EmptyName()
        {
            Player player = Player.CreateNewPlayer("");
        }

        // Should also return exception, since player name is an empty string.
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_CreateNewPlayer_EmptyName_MockedDataMapper()
        {
            var mock = new Mock<IPlayerDataMapper>();

            Player player = Player.CreateNewPlayer("", mock.Object);
        }


        // Should return exception, player already exists in "Database"
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_CreateNewPlayer_AlreadyExistsInDatabase()
        {
            var mock = new Mock<IPlayerDataMapper>();

            // Will return true for any name that is sent in.
            mock.Setup(x => x.PlayerNameExistsInDatabase(It.IsAny<string>())).Returns(true);

            Player player = Player.CreateNewPlayer("Test", mock.Object);
        }


        [TestMethod]
        public void Test_CreateNewPlayer_DoesNotExistInDatabase()
        {
            var mock = new Mock<IPlayerDataMapper>();

            // Will return false for any name that is sent in.
            mock.Setup(x => x.PlayerNameExistsInDatabase(It.IsAny<string>())).Returns(false);

            Player player = Player.CreateNewPlayer("Test", mock.Object);

            Assert.AreEqual("Test", player.Name);
            Assert.AreEqual(0, player.ExperiencePoints);
            Assert.AreEqual(10, player.Gold);
        }
    }
}
