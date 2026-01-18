using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace videogame.Races
{
    public class Barbarian : Character
    {
        public Barbarian(string username, string pClass) : base(username, "Barbarian", pClass, 8, 4, 0)
        {
        }
    }
}
