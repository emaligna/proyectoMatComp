using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo2
{
    // Node based AFN-ε.
    class AFN_N
    {
        const char _eps = '@';
        public Node initialNode;
        public List<Node> FreeNodes;
        public List<Transition> nullOut;
        public AFN_N()
        {
            initialNode = null;
            FreeNodes = new List<Node>();
            nullOut = new List<Transition>();
        }
        public void Link(AFN_N afn)
        {

            for (int i = 0; i < nullOut.Count; i++) 
                nullOut[i].destination = afn.initialNode;
            nullOut = afn.nullOut;
        }
        public void joinNull(List<Transition> outNull)
        {
                nullOut.AddRange(outNull);
        }
        public List<Node> getNodes()
        {
            Queue<Node> queue = new Queue<Node>();
            List<Node> nodes = new List<Node>();
            queue.Enqueue(initialNode);
            nodes.Add(initialNode);
            while (queue.Count > 0)
            {
                Node temp = queue.Dequeue();
                for (int i = 0; i < temp.transitions.Count; i++)
                {
                    Node temp2=temp.transitions[i].destination;
                    if (!nodes.Contains(temp2))
                    {
                        nodes.Add(temp2);
                        queue.Enqueue(temp2);
                    }
                }
            }
            return nodes;
        }
        //evaluation tools
        private List<T> union<T>(List<T> a, List<T> b)
        {
            for (int i = 0; i < b.Count; i++)
            {
                if (!a.Contains(b[i]))
                    a.Add(b[i]);
            }
            return a;
        }
        public bool hasEpsilonTransition(Node state)
        {
            for (int i = 0; i < state.transitions.Count; i++)
            {
                if (state.transitions[i].input == _eps)
                    return true;
            }
                return false;
        }
        //Returns the rachable states with epsilon alone.
        public List<Node> followEpsilon(Node state)
        {
            List<Node> result = new List<Node>();
            List<Node> check= new List<Node>();
            Node[] temp;
            bool epsilonFound = hasEpsilonTransition(state);
            result.Add(state);
            while (epsilonFound)
            {
                epsilonFound = false;
                temp = new Node[result.Count];
                result.CopyTo(temp);
                for (int i = 0; i < temp.Length; i++)
                {
                    Node cState = temp[i]; //for debug
                    if (!check.Contains(temp[i]))
                    {
                        check.Add(temp[i]);
                        bool NonEpsilonTransition = false;
                        for (int j = 0; j < temp[i].transitions.Count; j++)
                        {
                            Transition cTrans = temp[i].transitions[j];//for debug
                            if (temp[i].transitions[j].input == _eps)
                            {
                                epsilonFound = true;
                                if (!check.Contains(temp[i].transitions[j].destination) && !result.Contains(temp[i].transitions[j].destination))
                                    result.Add(temp[i].transitions[j].destination);
                            }
                            else
                                NonEpsilonTransition = true;
                        }
                        if (!NonEpsilonTransition && !temp[i].final)
                            result.Remove(temp[i]);
                    }
                }
            }
            return result;
        }

        private bool inRealAlphabet(char c)
        {
            List<char> ra = new List<char> {'a','b','c','d','e','f','g','h','i','j','k','l','m','n','ñ','o','p','q','r','s','t','u','v','w','x','y','z',
                                            'A','B','C','D','E','F','G','H','I','J','K','L','M','N','Ñ','O','P','Q','R','S','T','U','V','W','X','Y','Z',
                                            'á','é','í','ó','ú',
                                            'Á','É','Í','Ó','Ú',
                                            '0','1','2','3','4','5','6','7','8','9',
                                            ' ','.'};
            return ra.Contains(c);
        }
        public List<Node> transition(char input, List<Node> states)
        {
            List<Node> result= new List<Node>();
            foreach( Node state in states)
            {
                foreach (Transition trans in state.transitions)
                {
                    if (trans.input != _eps && (trans.input == input||(trans.input=='|'&& inRealAlphabet(input))) && !result.Contains(trans.destination)) 
                        result.Add(trans.destination);
                    //wildcard somewhere around here
                }
            }
            return result;
        }
        public bool evaluate(string input)
        {
            List<Node> currStates =new List<Node>{initialNode};
            List<Node> newStates = new List<Node>(); ;
            foreach (char c in input)
            {
                foreach (Node state in currStates)
                {
                    union(newStates, followEpsilon(state));
                }

                currStates = transition(c, newStates);
                newStates.Clear();
                
            }
            foreach (Node state in currStates)
            {
                union(newStates, followEpsilon(state));
            }
            foreach (Node state in newStates)
            {
                if (state.final)
                    return true;
            }
            return false;
        }
    }
        
}
