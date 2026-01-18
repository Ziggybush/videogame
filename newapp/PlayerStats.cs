using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using videogame.Races;

namespace videogame
{
    public class PlayerStats
    {
        public async Task showPlayerStats(Character player)
        {
            string[] playerStats =
            {
                $"Player Stats",
                $"----------------",
                $"\x1b[31m{player.Username}\x1b[0m",
                $"Race: {player.Race}",
                $"Class: {player.PClass}",
                $"HP: {player.HealthBar}",
                $"AD: {player.AttackDamage}",
                $"MD: {player.MagicDamage}",
                $"----------------"
            };
            await TextEffects.TypeLines(playerStats);
        }
    }
}
