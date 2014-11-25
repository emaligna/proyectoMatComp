using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomataND
{
    class Mod3
    {
        const char _eps = '@'; //ε
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
        //NEW
        public static bool hasEpsilonTransition(string state, AFN_E afn)
        {
            int i = afn.states.IndexOf(state);
            int j = afn.alphabet.IndexOf(_eps);
            if (i != -1 && j != -1)
                return afn.transitionMatrix[i][j].Count != 0;
            return false;
        }
        public static List<string> Closure(string state, AFN_E afn)
        {
            List<string> result = new List<string>();
            List<string> check = new List<string>();
            string[] temp;
            bool epsilonFound = hasEpsilonTransition(state, afn);
            result.Add(state);
            while (epsilonFound)
            {
                epsilonFound = false;
                temp = new string[result.Count];
                result.CopyTo(temp);
                for (int i = 0; i < temp.Length; i++)
                {
                    string cState = temp[i]; //for debug
                    if (!check.Contains(temp[i]))
                    {
                        check.Add(temp[i]);
                        bool NonEpsilonTransition = false;
                        //
                        for (int j = 0; j < afn.alphabet.Count; j++)
                        {
                            int index=afn.states.IndexOf(temp[i]);
                            if (index != -1)
                            {
                                //check for epsilon transition
                                
                                if (afn.transitionMatrix[index][j].Count!=0)
                                {
                                    if (j == 0)
                                    {
                                        epsilonFound = true;
                                        for (int k = 0; k < afn.transitionMatrix[index][j].Count; k++)
                                        {
                                            string destination = afn.transitionMatrix[index][j][k];
                                            if (!check.Contains(destination) && !result.Contains(destination))
                                                result.Add(destination);
                                        }
                                    }
                                    else
                                        NonEpsilonTransition = true;

                                }
                            }

                                
                        }
                        if (!NonEpsilonTransition && ! afn.finalStates.Contains(temp[i]))
                            result.Remove(temp[i]);
                    }
                }
            }
            return result;
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
        public static bool hasFinal(List<string> states, AFN_E afn)
        {
            for (int i = 0; i < states.Count; i++)
                if (afn.finalStates.Contains(states[i]))
                    return true;
            return false;
        }
        public static void removeEpsilon(AFN_E afn)
        {
            Queue<List<string>> stateQueue = new Queue<List<string>>();
            List<string> newStates = new List<string>();
            List<string> closureTemp = new List<string>();
            List<char> newAlphabet = new List<char>();
            List<string> newFinal = new List<string>();
            for (int i = 1; i < afn.alphabet.Count; i++)
                newAlphabet.Add(afn.alphabet[i]);

            List<List<List<string>>> newMatrix = new List<List<List<string>>>();
            string newInitial = "";
            closureTemp = Closure(afn.initialState, afn);
            closureTemp.Sort();
            newInitial=string.Join("#", closureTemp);
            newStates.Add(newInitial);
            
            newMatrix.Add(new List<List<string>>());
            for (int l = 0; l < newAlphabet.Count; l++)
            {
                newMatrix[0].Add(new List<string>());
            }
            stateQueue.Enqueue(closureTemp);
            while (stateQueue.Count != 0)
            {
                //already on closure
                List<string> tempStates = stateQueue.Dequeue();
                string currState= string.Join("#",tempStates);
                
                //for every simbol
                for (int j = 0; j < newAlphabet.Count;j++ ) 
                {
                    char input = afn.alphabet[j];
                    //transition
                    List<string> transitionStates = new List<string>();
                    for (int i = 0; i < tempStates.Count; i++)
                    {
                        union(transitionStates, afn.transition(tempStates[i], input));
                    }
                    //Closure
                    closureTemp = new List<string>();
                    for (int i = 0; i < transitionStates.Count; i++)
                    {
                        union(closureTemp, Closure(transitionStates[i], afn));
                    }
                    closureTemp.Sort();
                    string state = string.Join("#", closureTemp);
                    state= state==""?"Ø":state;
                    if (!newStates.Contains(state))
                    {
                        if (hasFinal(closureTemp, afn))
                            newFinal.Add(state);

                        newStates.Add(state);
                        stateQueue.Enqueue(closureTemp);
                        int index= newStates.IndexOf(currState);
                        
                        newMatrix.Add(new List<List<string>>());

                        for (int l = 0; l < newAlphabet.Count; l++)
                        {
                            newMatrix[newMatrix.Count-1].Add(new List<string>());
                        }
                            newMatrix[index][j].Add(state);
                    }
                }
            }
            afn.alphabet = newAlphabet;
            afn.states = newStates;
            afn.initialState = newInitial;
            afn.transitionMatrix = newMatrix;
            afn.finalStates = newFinal;
            afn.hasEpsilon = false;
            //rename states
            for (int i = 0; i < afn.states.Count; i++)
            {
                string oldName = afn.states[i];
                string newName = "q" + i;
                afn.states[i] = newName;
                if(afn.finalStates.Contains(oldName)){
                    afn.finalStates[afn.finalStates.IndexOf(oldName)]=newName;
                }
                for (int l = 0; l < afn.transitionMatrix.Count; l++)
                    for (int j = 0; j < afn.transitionMatrix[l].Count; j++)
                        for (int k = 0; k < afn.transitionMatrix[l][j].Count; k++)
                            if (afn.transitionMatrix[l][j][k] == oldName)
                                afn.transitionMatrix[l][j][k] = newName;
            }
            afn.initialState = "q0";
        }
        
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
            if (!afn.hasEpsilon) return;
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
            afn.hasEpsilon = false;
        }
        
    }
}
