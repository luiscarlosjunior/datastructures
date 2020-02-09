using WarriorWars.Enum;

namespace WarriorWars.Equipaments
{
    internal class Armor
    {
        private const int GOOD_GUY_ARMOR = 5;
        private const int BAD_GUY_ARMOR = 5;

        private int armorPoints;

        public int ArmorPoints { 
            get { return armorPoints; } 
        }

        public Armor(Faction faction)
        {
            switch (faction)
            {
                case Faction.GoodBoy:
                    armorPoints = GOOD_GUY_ARMOR;
                    break;
                case Faction.BadBoy:
                    armorPoints = BAD_GUY_ARMOR;
                    break;
                default:
                    break;
            }
        }
    }
}