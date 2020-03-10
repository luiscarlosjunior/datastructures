using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarriorWars
{
    class Program
    {
        static Random rnd = new Random();

        static void Main(string[] args)
        {
            Warrior goodGuy = new Warrior("Dunka", Enum.Faction.GoodBoy);
            Warrior badGuy = new Warrior("Dunty", Enum.Faction.BadBoy);

            while (goodGuy.IsAlive && badGuy.IsAlive)
            {
                if (rnd.Next(0, 10) < 5)
                {
                    goodGuy.Attack(badGuy);
                }
                else
                {
                    badGuy.Attack(goodGuy);
                }
            }
        }
    }
}
