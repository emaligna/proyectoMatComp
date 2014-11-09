using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo2
{
    class Program
    {
        //console print AFN-ε (not node based), for testing purpouses.
        public static void printAFN(AFN_E afn)
        {
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
                        Console.Write("\t|" + afn.alphabet[j]);
                    else
                        Console.Write("\t|" + string.Join(",", afn.transitionMatrix[i][j].ToArray()));
                }
                Console.WriteLine();
                Console.WriteLine("_____________________________________________");
            }
        }
        //parse to .afn style string, in case needed.
        public static string AFNtoString(AFN_E afn)
        {
            string afnS = "";
            afnS += string.Join(",", afn.alphabet.ToArray()) + "\n";
            for (int i = 0; i < afn.transitionMatrix.Count; i++)
            {
                afnS += (afn.finalStates.Contains(afn.states[i]) ? "*" : "") + afn.states[i] + "-";
                for (int j = 0; j < afn.alphabet.Count; j++)
                {
                    afnS += afn.transitionMatrix[i][j].Count > 0 ? string.Join("&", afn.transitionMatrix[i][j].ToArray()) : "%";
                    afnS += (j == afn.alphabet.Count - 1 ? "\n" : ",");
                }
            }
            return afnS;
        }
        static void Main(string[] args)
        {
            Mod2 test = new Mod2();
            test.computeAFN_E("bb&*a&bb&+&c&");
            printAFN(test.result);
            Console.WriteLine("\nParsed AFN string:\n\n" + AFNtoString(test.result));

           
        }
    }
}
