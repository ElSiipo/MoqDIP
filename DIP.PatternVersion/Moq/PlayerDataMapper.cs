using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP.PatternVersion.Moq
{
    public class PlayerDataMapper : IPlayerDataMapper
    {
        private readonly string _connectionString = "";

        public bool PlayerNameExistsInDatabase(string name)
        {
            throw new NotImplementedException();
        }

        public void InsertNewPlayerIntoDatabase(string name)
        {
            throw new NotImplementedException();
        }
    }
}
