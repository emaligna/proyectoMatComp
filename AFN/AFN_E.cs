using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace AutomataND
{
    //Old format AFN-ε, with lists to represent state, alphabet, links.
    class AFN_E
    {
        //Epsilon constant.
        const char _eps = '@'; //ε
        public List<char> alphabet;
        public List<string> states;
        public List<List<List<string>>> transitionMatrix;
        public string initialState;
        public List<string> finalStates;

        bool hasEpsilon;

        public AFN_E()
        {
            alphabet = new List<char>();
            alphabet.Add(_eps);
            states = new List<string>();
            transitionMatrix = new List<List<List<string>>>();
            initialState="";
            finalStates = new List<string>();
            hasEpsilon = true;

        }
        public AFN_E(List<string> st, List<char> al, string i, List<List<List<string>>> tm, List<string> f, bool eps=true)
        {
            states = st;
            alphabet = al;
            initialState = i;
            transitionMatrix = tm;
            finalStates = f;
            hasEpsilon = eps;
        }
        //TODO
        public void removeEps()
        {

        }
        //TODO
        public bool eval(string input)
        {
            if (hasEpsilon)
            {
                Console.WriteLine("Has epsilon, can't eval");
                return false;
            }
            return evalu(input);
        }

        public void clear() 
        {
            transitionMatrix = new List<List<List<string>>>();
            states = new List<string>();
            alphabet = new List<char>();
            finalStates = new List<string>();
            initialState = "";
        }

        //New parse
        public bool parser(string path)
        {
            clear();
            try
            {
                //Make file into string array of lines
                string[] lines = System.IO.File.ReadAllLines(path);
                //First line, save alphabet
                string[] temp = lines[0].Split(',');
                for (int i = 0; i < temp.Length; i++)
                {
                    alphabet.Add(temp[i][0]);
                }
                //Save first state may be incessary
                temp = lines[1].Split('-');
                initialState = temp[0][0] == '*' ? temp[0].Substring(1) : temp[0];
                //end of ineccesary

                for (int i = 1; i < lines.Length; i++)
                {
                    temp = lines[i].Split('-');
                    //asigning states
                    if (i == 1)
                        initialState = temp[0][0] == '*' ? temp[0].Substring(1) : temp[0];
                    if (temp[0][0] == '*')
                    {
                        finalStates.Add(temp[0].Substring(1));
                        states.Add(temp[0].Substring(1));
                    }
                    else
                        states.Add(temp[0]);

                    //Create matrix
                    temp = temp[1].Split('&');
                    List<List<string>> tempList = new List<List<string>>();
                    for (int j = 0; j < temp.Length; j++)
                    {
                        tempList.Add(temp[j].Split(',').ToList<string>());
                    }
                    transitionMatrix.Add(tempList);
                }
                hasEpsilon = this.alphabet.Contains('@');
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

         //Automata methods
         private int symbol(char c)
         {
             return alphabet.IndexOf(c);
         }
         private int state(string s)
         {
             return states.IndexOf(s);
         }
         private List<string> transition(string state, char c)
         {
             int i=this.state(state);
             int j=this.symbol(c);
             if (i != -1 && j != -1)
             {
                 return this.transitionMatrix[i][j];
             }
             return new List<string>();
         }
         List<string> union(List<string> a, List<string> b)
         {
             for (int i = 0; i < b.Count; i++)
             {
                 if(!a.Contains(b[i]))
                     a.Add(b[i]);
             }
             return a;
         }
         private bool evalu(string s)
         {
             List<string> curState = new List<string>(); //Array of currentStates
             curState.Add(this.initialState); // add initial states
             for (int i = 0; i < s.Length; i++)
             {
                 List<string> newStates= new List<string>();
                
                 //repeat for every current state
                 for (int j = 0; j < curState.Count; j++)
                 {
                     List<string> tempS = new List<string>();
                     tempS = union(newStates, transition(curState[j], s[i]));
                     newStates = tempS;

                 }
                 curState = newStates;
             }
             //see if thereis a final state
             for (int i = 0; i < curState.Count; i++)
             {
                 if (finalStates.Contains(curState[i]))
                     return true;
             }
             return false;
         }

    }
}
