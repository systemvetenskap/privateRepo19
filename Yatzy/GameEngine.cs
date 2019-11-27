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
        private Random random = new Random(); // skapa slumpgenerator = hemlig för omvärlden
        private int[] dices = new int[5];


        // publika properties
        public int Ones { get; private set; }
        public int Twos { get; private set; }
        public int Threes { get; private set; }
        public int Fours { get; private set; }
        public int Fives { get; private set; } // private setter 
        public int Sixes { get; private set; }
        public int Bonus => CalculateBonus();
        public int Total => CalculateSum();

        private int CalculateBonus()
        {
            if (CalculateSum() > 5)
            {
                return 50;
            }
            return 0;
        }
        private int CalculateSum()
        {
            int totalSum = Ones + Twos + Threes + Fours + Fives + Sixes;
            return totalSum;
        }

        /// <summary>
        /// Check if a score is valid for this category
        /// </summary>
        /// <returns></returns>
        private bool IsValidScore(int score, int category)
        {
            int dicesCount = 5;
            // kollar extremvärden
            if (score < 0 || score > category * dicesCount)
            {
                return false;
            }
            else if (score % category !=0)
            {
                return false;
            }
            return true;
        }

        private bool IsCategoryAvailable(int category)
        {
            switch (category)
            {
                case 1:
                    if (Ones == 0)
                    {
                        return true;
                    }
                    break;
                
            }
            return false;
        }

       // uppdrag:
       // spara poängen om den är ok sett från regelperspektiv

            /// <summary>
            /// Spara poängen för vald kategori
            /// </summary>
            /// <param name="score"></param>
            /// <param name="category"></param>
            /// <returns></returns>
        public bool SaveScore(int score, int category)
        {
            // ! Vänder på min if-sats
            // alltså INTE är
            // använder en annan metod
            if (!IsValidScore(score, category))
            {
                return false;
            }
            else if (!IsCategoryAvailable(category))
            {
                return false;
            }
            else
            {
                // Vi använder en switch (kallas också för case)
                // Typ samma som många if-satser
                switch (category)
                {
                    case 1:
                        Ones = score;
                        break;
                    case 2:
                        Twos = score;
                        break;
                    case 3:
                        Threes = score;
                        break;
                    case 4:
                        Fours = score;
                        break;
                    case 5:
                        Fives = score;
                        break;
                    case 6:
                        Sixes = score;
                        break;
                }
                return true;
            }

        }

        public void SaveScore(int category)
        {
            switch (category)
            {
                case 1:
                    Ones = SumDices(1);
                    break;
                case 2:
                    Twos = SumDices(2);
                    break;
                case 3:
                    Threes = SumDices(3);
                    break;
                case 4:
                    Fours = SumDices(4);
                    break;
                case 5:
                    Fives = SumDices(5);
                    break;
                case 6:
                    Sixes = SumDices(6);
                    break;
            }
        }
        // Uppdrag: Gör en metod som kastar en tärning
        public int RoleDie()
        {
           return random.Next(1, 7);
        }

        // vi har gjort en överlagrad metod
        // samma metod finns i flera olika varianter.
        // variant = olika antal, eller typ, av indataparmeter
        /// <summary>
        /// Kasta alla tärningar
        /// </summary>
        /// <returns></returns>
        public int[] RoleDices()
        {
            for (int i = 0; i < 5; i++)
            {
                dices[i] = RoleDie();
            }
            return dices;

        }
        /// <summary>
        /// Kasta de tärningar som vi inte har sparat
        /// </summary>
        /// <param name="savedDices"></param>
        /// <returns></returns>
        public int[] RoleDices(bool[] savedDices)
        {
            for (int i = 0; i < 5; i++)
            {
                if (!savedDices[i])
                {
                    dices[i] = RoleDie();
                }
            }
            return dices;
        }

        private int SumDices(int category)
        {
            int sum = 0;
            foreach(int die in dices)
            {
                if (die == category)
                {
                    sum += die;
                }
            }
            return sum;
        }
    }
}
