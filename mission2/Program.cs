using System;

namespace C_sharp_is_super_fun
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int[] rollResults = new int[11];

            for (int i = 0; i < 100; i++)
            {
                int currRoll = r.Next(1, 7);
                currRoll += r.Next(1, 7);
                rollResults[currRoll - 2] += 1;
                currRoll = 0;
            }

            for (int i = 0; i < rollResults.Length; i++)
            {
                float numStars = (rollResults[i] / (float)100) * 100;
                string numStarsString = "";

                for (int z = 0; z < numStars; z++)
                {
                    numStarsString += "*";
                }

                Console.WriteLine((i + 2) + ": " + numStarsString + " " + numStars);
            }
        }
    }
}