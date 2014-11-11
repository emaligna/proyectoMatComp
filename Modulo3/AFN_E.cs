using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Modulo3
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
            return true;
        }

    }
}
