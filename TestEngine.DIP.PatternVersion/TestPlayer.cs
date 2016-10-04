using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DIP.PatternVersion.Moq;

namespace TestEngine.DIP.PatternVersion
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
            MockPlayerDataMapper mockPlayerDataMapper = new MockPlayerDataMapper();

            Player player = Player.CreateNewPlayer("", mockPlayerDataMapper);
        }


        // Should return exception, player already exists in "Database"
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_CreateNewPlayer_AlreadyExistsInDatabase()
        {
            MockPlayerDataMapper mockPlayerDataMapper = new MockPlayerDataMapper();
            mockPlayerDataMapper.ResultToReturn = true;

            Player player = Player.CreateNewPlayer("Test", mockPlayerDataMapper);
        }


        [TestMethod]
        public void Test_CreateNewPlayer_DoesNotExistInDatabase()
        {
            MockPlayerDataMapper mockPlayerDataMapper = new MockPlayerDataMapper();
            mockPlayerDataMapper.ResultToReturn = false;

            Player player = Player.CreateNewPlayer("Test", mockPlayerDataMapper);

            Assert.AreEqual("Test", player.Name);
            Assert.AreEqual(0, player.ExperiencePoints);
            Assert.AreEqual(10, player.Gold);
        }
    }
}
