using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo2
{
    class Program
    {
        //public static string toString<>(List)
        public static void printAFN(AFN_E afn)
        {
           // string dogCsv = string.Join(",", dogs.ToArray());
            Console.WriteLine("  States: " + string.Join(",", afn.states.ToArray()));
            Console.WriteLine("Alphabet: " + string.Join(",", afn.alphabet.ToArray()));
            Console.WriteLine(" Initial: " + afn.initialState);
            Console.WriteLine("   Final: " + string.Join(",", afn.finalStates.ToArray()));
            Console.WriteLine("Transition Matrix:");
            for (int i = -1; i < afn.transitionMatrix.Count; i++)
            {
                if(i>-1)
                    Console.Write(afn.states[i] + ":");
                for (int j = 0; j < afn.alphabet.Count; j++)
                {
                    if (i == -1)
                        Console.Write("\t" + afn.alphabet[j]+"|");
                    else
                        Console.Write("\t" + string.Join(",", afn.transitionMatrix[i][j].ToArray())+"|");
                }
                Console.WriteLine();
                Console.WriteLine("_____________________________________________");
            }
            

        }
        static void Main(string[] args)
        {
            Mod2 test = new Mod2();
            test.computeAFN_E("bb&*a&bb&+&c&");
            printAFN(test.result);
            

           
        }
    }
}
