using System;
using DIP.PatternVersion.Moq;

namespace TestEngine.DIP.PatternVersion
{
    internal class MockPlayerDataMapper : IPlayerDataMapper
    {
        public bool ResultToReturn { get; set; }

        public void InsertNewPlayerIntoDatabase(string name)
        {
        }

        public bool PlayerNameExistsInDatabase(string name)
        {
            return ResultToReturn;
        }
    }
}