using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringToSeed
{
    class Program
    {
        static void Main(string[] args)
        {
            const int _BATCHSIZE = 16;
            char[] charset = "ABCDEFGHIJKLMNOPQRSTUVWXYZ ".ToCharArray();

            string _INPUT = "ROGAN MATRIVSKI LARTENGALF";

            int seed = 0;
            bool found = false;

            while (!found)
            {
                Random rand = new Random(seed);
                char[] result = new char[_INPUT.Length];

                for (int i = 0; i < result.Length; i++)
                {
                    result[i] = charset[rand.Next(0, charset.Length)];
                }

                string res = new string(result);

                Console.WriteLine($"Testing seed {seed}");
                if (_INPUT == res)
                {
                    found = true;
                    break;
                }

                seed++;
            }

            Console.WriteLine($"Found seed {seed} matching for {_INPUT}");
        }
    }
}
