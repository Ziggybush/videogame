using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using videogame.Actions;

namespace videogame.Races
{
    public class Human : Character
    {
        public Human(string username, string pClass) : base(username, "Human", pClass, 10, 3, 2) 
        {
        }
    }
}
