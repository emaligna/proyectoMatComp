using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Modulo2
{   
    /// <summary>
    /// This class represents Non Deterministic Finite Automatons, with epsilon transition.
    /// </summary>
    class AFN_E
    {
        //Epsilon constant.
        const char _eps = '@'; //ε
        public List<char> alphabet;
        public List<string> states;
        public List<List<List<string>>> transitionMatrix;
        public string initialState;
        public List<string> finalStates;

        public AFN_E()
        {
            alphabet = new List<char>();
            alphabet.Add(_eps);
            states = new List<string>();
            transitionMatrix = new List<List<List<string>>>();
            initialState="";
            finalStates = new List<string>();

        }
        public AFN_E(List<string> st, List<char> al, string i, List<List<List<string>>> tm, List<string> f)
        {
            states = st;
            alphabet = al;
            initialState = i;
            transitionMatrix = tm;
            finalStates = f;
        }

        




    }
}
