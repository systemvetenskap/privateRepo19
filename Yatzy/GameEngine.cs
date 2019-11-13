using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yatzy
{
    class GameEngine
    {
        // instansvariabel
        Random random = new Random(); // skapa slumpgenerator

        

        // Uppdrag: Gör en metod som kastar en tärning
        public int RoleDie()
        {
           return random.Next(1, 7);
        }

        public int[] RoleDices()
        {
            int[] dices = new int[5];

            for (int i = 0; i < 5; i++)
            {
                dices[i] = RoleDie();
            }
            return dices;
        }
    }
}
