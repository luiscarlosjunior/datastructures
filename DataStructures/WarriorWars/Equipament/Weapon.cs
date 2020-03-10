using WarriorWars.Enum;

namespace WarriorWars.Equipaments
{
    internal class Weapon
    {
        private int damage;
        private const int GOOD_BOY_DAMAGE = 5;
        private const int BAD_GUY_DAMAGE = 5;

        public int Damage
        {
            get { return damage; }

        }

        public Weapon(Faction faction)
        {
            switch (faction)
            {
                case Faction.GoodBoy:
                    damage = GOOD_BOY_DAMAGE;
                    break;
                case Faction.BadBoy:
                    damage = BAD_GUY_DAMAGE;
                    break;
                default:
                    break;
            }
        }
    }
}