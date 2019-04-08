using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarriorDeathMatch
{
    class Program
    {
        // Application Synopsis:
        //    Warriors rotate attacking each other until
        //    one dies and the other is victorious
        //
        // Various Output:
        // {} attacks {} and Deals {} Damage
        // {} Has {} Health
        // {} has Died and {} is Victorious

        // *****************************

            
        static void Main(string[] args)
        {
            Warrior emmalani = new Warrior("Emmalani", 1000, 120, 40);

            Warrior mana = new Warrior("Mana", 1000, 120, 40);

            Battle.StartFight(emmalani, mana);

            Console.ReadLine();
        }
    }
}
