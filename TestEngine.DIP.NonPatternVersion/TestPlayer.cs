using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DependencyInversionPattern;

namespace TestEngine.DIP.PatternVersion
{
    [TestClass]
    public class TestPlayer
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_CreateNewPlayer_EmptyName()
        {
            Player player = Player.CreateNewPlayer("");
        }
    }
}
