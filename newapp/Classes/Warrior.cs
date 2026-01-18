using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using videogame.Actions;

namespace videogame.Classes
{
    public class Warrior
    {
        private readonly Attacker Attacker = new Attacker();
        public void Attack() => Attacker.Attack();
    }
}
