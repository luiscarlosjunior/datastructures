using System;
using WarriorWars.Enum;
using WarriorWars.Equipaments;
using System.Threading;

namespace WarriorWars
{
    class Warrior
    {
        private const int GOOD_GUY_STARTING_HEALTH = 100;
        private const int BAD_GUY_STARTING_HEALTH = 100;

        private readonly Faction FACTION;

        private int health;
        private string name;
        private bool isAlive;

        public bool IsAlive {
            get { return isAlive; }  
            }

        private Weapon weapon;
        private Armor armor;

        public Warrior(string name, Faction faction)
        {
            this.name = name;
            FACTION = faction;
            this.isAlive = true;

            switch (faction)
            {
                case Faction.GoodBoy:
                    weapon = new Weapon(faction);
                    armor = new Armor(faction);
                    health = GOOD_GUY_STARTING_HEALTH;
                    break;
                case Faction.BadBoy:
                    weapon = new Weapon(faction);
                    armor = new Armor(faction);
                    health = BAD_GUY_STARTING_HEALTH;
                    break;
                default:
                    break;
            }
        }

        public void Attack(Warrior enemy)
        {
            int damage = weapon.Damage / enemy.armor.ArmorPoints;

            enemy.health -= damage;

            AttackResult(enemy, damage);

        }

        private void AttackResult(Warrior enemy, int damage)
        {
            if (enemy.health <= 0)
            {
                enemy.isAlive = false;
                Console.WriteLine($"{enemy.name} is dead! {name} is victorious!");
            }
            else
            {
                Console.WriteLine($"{name} attacked {enemy.name}. {damage} was inflicted to {enemy.name} \n remaining health of {enemy.name} is {enemy.health}");
            }
            Thread.Sleep(500);
        }
    }
}
