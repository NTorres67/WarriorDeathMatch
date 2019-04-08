using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarriorDeathMatch
{
    class Warrior
    {
        // Properties Required:  Name, Health, Attack Max, Block Max
        public string Name { get; set; } = "Warrior";
        public double Health { get; set; } = 0;
        public double AttackMax { get; set; } = 0;
        public double BlockMax { get; set; } = 0;

        // Random number generator for attacks and blocks to be reused
        Random rnd = new Random();

        // Constructor -
        public Warrior(string name = "Warrior", double health = 0, double attackMax = 0, double blockMax = 0)
        {
            Name = name;
            Health = health;
            AttackMax = attackMax;
            BlockMax = blockMax;
        }

        // Attack Method: Random attack value from 1 to maximum
        public double Attack()
        {
            return rnd.Next(1, (int)AttackMax);
        }

        // Block Method: Random block value from 1 to maximum
        public double Block()
        {
            return rnd.Next(1, (int)BlockMax);
        }




    }
}
