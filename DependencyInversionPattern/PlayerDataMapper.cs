using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPattern
{
    public class PlayerDataMapper : IPlayerDataMapper
    {
        internal bool PlayerNameExistsInDatabase(string name)
        {
            throw new NotImplementedException();
        }

        internal void InsertNewPlayerIntoDatabase(string name)
        {
            throw new NotImplementedException();
        }

        bool IPlayerDataMapper.PlayerNameExistsInDatabase(string name)
        {
            throw new NotImplementedException();
        }

        void IPlayerDataMapper.InsertNewPlayerIntoDatabase(string name)
        {
            throw new NotImplementedException();
        }
    }
}
