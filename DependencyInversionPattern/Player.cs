using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPattern
{
    public class Player
    {
        public string Name { get; private set; }
        public int ExperiencePoints { get; private set; }
        public int Gold { get; private set; }

        public Player(string name, int experiencePoints, int gold)
        {
            Name = name;
            ExperiencePoints = experiencePoints;
            Gold = gold;
        }

        public static Player CreateNewPlayer(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Player name cannot be empty.");

            PlayerDataMapper _playerDataMapper = new PlayerDataMapper();

            if (_playerDataMapper.PlayerNameExistsInDatabase(name))
                throw new ArgumentException("Player name already exists.");

            _playerDataMapper.InsertNewPlayerIntoDatabase(name);

            return new Player(name, 0, 10);
        }
    }
}
