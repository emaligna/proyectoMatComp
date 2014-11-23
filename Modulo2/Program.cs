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
        public static void print<T>(List<T> list)
        {
            Console.Write("[");
             for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + (i == list.Count - 1 ? "" : ","));
            }
             Console.WriteLine("]"); 
        }
        private static List<T> union<T>(List<T> a, List<T> b)
        {
            for (int i = 0; i < b.Count; i++)
            {
                if (!a.Contains(b[i]))
                    a.Add(b[i]);
            }
            return a;
        }
        static void Main(string[] args)
        {
            //string regex = "((tu,ami)*(@,les)+)*,(enteró)*((b,c,d),.)";
            //string regex = "m(a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,j,r,s,t,u,v,w,x,y,z)*";
            string regex = "|*";
            
            Console.WriteLine("Regex: " + regex);
            Mod1 m1 = new Mod1(regex);
            Mod2 m2 = new Mod2();
            m2.computeAFN_E(m1.getResult());
            AFN_N afn = m2.NBresult;
            Console.WriteLine("Initial State: " + m2.NBresult.initialNode);
            //string eval = "SOLASJI0SOLadosSOL0q";
            //string eval = "melones grandes";
            
            string text = "Tom & Jerry";
            List<string> match = afn.textEval(text);
            List<char> ctest = afn.startAlphabet();

            Console.Write("initial: ");
            print<char>(ctest);

           // Console.WriteLine("Evaluating string: " + eval);
            //Console.WriteLine((m2.NBresult.evaluate(eval) ? "" : "Not ") + "Acepted");
            print<string>(match);
           
        }
    }
}
