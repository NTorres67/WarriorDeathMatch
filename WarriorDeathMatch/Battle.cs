using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarriorDeathMatch
{
    class Battle
    {
        // StartFight Method
        // Parameters: Warrior1, Warrior2
        public static void StartFight(Warrior warrior1, Warrior warrior2)
        {
            // Loop giving each warrior to attack & attack until 1 dies
            while (true)
            {
                if (GetAttackResults(warrior1, warrior2) == "Game Over")
                {
                    Console.WriteLine("Game Over");
                    break;
                }

                if (GetAttackResults(warrior2, warrior1) == "Game Over")
                {
                    Console.WriteLine("Game Over");
                    break;
                }
            }
        }
        // GetAttackResults Method
        // Parameters: WarriorA, WarriorB
        public static string GetAttackResults(Warrior warriorA, Warrior warriorB)
        {
            // Calculate 1 warriors attack the others block
            double warriorAAttackAmmount = warriorA.Attack();
            double warriorBBlockAmmount = warriorB.Block();

            // Subtract block from attack
            double damage2WarriorB = warriorAAttackAmmount - warriorBBlockAmmount;

            // If there was damage, subtract that from the health of the other
            if (damage2WarriorB > 0)
            {
                warriorB.Health = warriorB.Health - damage2WarriorB;
            }
            else damage2WarriorB = 0;

            // Print out info on who attacked who and for how much damage
            Console.WriteLine("{0} Attacks {1} and Deals {2} Damage", warriorA.Name, warriorB.Name, damage2WarriorB);

            // Provide output on the change in health
            Console.WriteLine("{0} Has {1} Health\n", warriorB.Name, warriorB.Health);

            // Check if the warrior's Health fell below 0 and if so, 
            // print a message and then send a response that will end the loop
            if (warriorB.Health <= 0)
            {
                Console.WriteLine("{0} has Died and {1} is Victorious\n", warriorB.Name, warriorA.Name);

                return "Game Over";
            }
            else return "Fight Again";

        }

    }
}
