using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace videogame.Classes
{
    public class Mage
    {
        private readonly Actions.MagicAttacker MagicAttacker = new Actions.MagicAttacker();
        public void CastSpell() => MagicAttacker.CastSpell();
    }
}
