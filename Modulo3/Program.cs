using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo3
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
       //calcula epsilon cerradura
        public static string Cerradura(AFN_E afn,string state)
        {
            string c1 = string.Join(",", afn.transitionMatrix[afn.states.IndexOf(state)][afn.alphabet.IndexOf('@')]);
            string s = state;
            if (c1 != "")
            {
                List<string> ce1 = afn.transitionMatrix[afn.states.IndexOf(state)][afn.alphabet.IndexOf('@')].ToList();
                for (int i = 0; i < ce1.Count; i++)
                {
                    s+=","+Cerradura(afn, ce1[i]);
                }
            } 
            return s;
           
        }
        public static List<string> Ordena(List<string>lista, AFN_E afn) {
            List<string> nueva = new List<string>(lista.Count);
            for (int i = 0; i < afn.states.Count; i++) { 
                if(lista.Contains(afn.states[i]))nueva.Add(afn.states[i]);
            }
            return nueva;
        }
        public static Boolean iguales(List<string> l1, List<string> l2)
        {
            for (int i = 0; i < l1.Count; i++)
            {
                if(l1[i]!=l2[i])return false;
            }
            return true;
        }
        public static void quitaEpsilon(AFN_E afn) {
            List<List<string>> cerraduras = new List<List<string>>();
            List<string> nestados = new List<string>();
            for (int i = 0; i < afn.states.Count; i++)
            {
                cerraduras.Add(Cerradura(afn,afn.states[i]).Split(',').ToList());
            }
            int einicial = afn.states.IndexOf(afn.initialState);
            List<List<List<string>>> Matriz = new List<List<List<string>>>();
            nestados.Add(string.Join(",", Ordena(cerraduras[einicial], afn)));


            for (int i = 0; i < nestados.Count; i++)
            {
                Matriz.Add(new List<List<string>>());
                for (int k = 0; k < afn.alphabet.Count - 1; k++)
                {
                    Matriz[i].Add(new List<string>(afn.alphabet.Count - 1));
                    string est = "";
                    List<string> ne = nestados[i].Split(',').ToList();
                    for (int j = 0; j < ne.Count; j++)
                    {

                        List<string> t = afn.transitionMatrix[afn.states.IndexOf(ne[j])][k + 1].ToList();
                        for (int d = 0; d < t.Count; d++)
                        {
                            if (est != "") est += ",";
                            est += string.Join(",", cerraduras[afn.states.IndexOf(t[d])]);
                        }

                    }


                    string fg = string.Join(",", Ordena(est.Split(',').ToList(), afn));
                    if (!nestados.Contains(fg) && fg.Trim() != "") nestados.Add(fg);
                    if (nestados.IndexOf(fg) >= 0) Matriz[i][k].Add("q" + nestados.IndexOf(fg).ToString());
                    else Matriz[i][k].Add("");

                }

            }
            List<string> finales = new List<string>();
            for (int i = 0; i < nestados.Count; i++)
            {
                List<string> s = nestados[i].Split(',').ToList();
                for (int r = 0; r < s.Count; r++)
                {
                    if (afn.finalStates.Contains(s[r]))
                    {
                        r = s.Count;
                        finales.Add("q" + i.ToString());
                    }
                }
                nestados[i] = "q" + i.ToString();
            }
            afn.states = nestados;
            afn.transitionMatrix = Matriz;
            afn.initialState = nestados[0];
            afn.alphabet.RemoveAt(0);
            afn.finalStates = finales;
        }
        
        static void Main(string[] args)
        {
            Mod2 test = new Mod2();
            test.computeAFN_E("bb&*a&bb&+&c&");
            quitaEpsilon(test.result);
            printAFN(test.result);
            Console.ReadLine();

           
        }
    }
}
