using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace videogame.Races
{
    public abstract class Character
    {
        public static readonly string[] AvailableRaces = { "Human", "Dark Elf", "High Elf", "Barbarian" };

        public Character(string username, string race, string pClass, int healthBar, int attackDamage, int magicDamage) 
        {
            Username = username;
            Race = race;
            PClass = pClass;
            HealthBar = healthBar;
            AttackDamage = attackDamage;
            MagicDamage = magicDamage;
        }

        public string Username { get; set; }
        public string Race { get; set; }
        public string PClass { get; set; }
        public int HealthBar { get; set; }
        public int AttackDamage { get; set; }
        public int MagicDamage { get; set; }
    }
}
