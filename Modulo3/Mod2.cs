using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo3
{
  
    class Mod2
    {
        const char _eps = '@'; //ε
        public AFN_E result = new AFN_E();      //old format AFN-ε
        public AFN_N NBresult = new AFN_N();    //node based AFN-ε
      
       
        private void toAFN_E(AFN_N afnN)
        {
            List<char> alphabet = new List<char>();
            alphabet.Add(_eps);
            List<string> states = new List<string>();
            List<List<List<string>>> transitionMatrix = new List<List<List<string>>>();
            string initialState = afnN.initialNode.name;
            List<string> finalStates = new List<string>();

            //graph traversal
            Queue<Node> queue = new Queue<Node>();
            List<Node> nodes = new List<Node>();
            queue.Enqueue(afnN.initialNode);
            states.Add(initialState);
            nodes.Add(afnN.initialNode);
            while (queue.Count > 0)
            {
                Node temp = queue.Dequeue();
                for (int i = 0; i < temp.transitions.Count; i++)
                {
                    char c = temp.transitions[i].input;
                    if (!alphabet.Contains(c))
                    {
                        alphabet.Add(c);
                    }
                        

                    Node temp2 = temp.transitions[i].destination;
                    if (!nodes.Contains(temp2))
                    {
                        nodes.Add(temp2);
                        queue.Enqueue(temp2);
                        states.Add(temp2.name);
                    }
                }
            }
            for (int i = 0; i < states.Count; i++)
            {
                transitionMatrix.Add(new List<List<string>>());
                for (int j = 0; j < alphabet.Count; j++)
                {
                    transitionMatrix[i].Add(new List<string>());
                }
                Node temp=nodes[i];
                if (temp.final)
                    finalStates.Add(temp.name);
                for (int k = 0; k < temp.transitions.Count; k++)
                {
                    transitionMatrix[i][alphabet.IndexOf(temp.transitions[k].input)].Add(temp.transitions[k].destination.name);
                }
            }
            result = new AFN_E(states, alphabet, initialState, transitionMatrix, finalStates);
           
        }
        private void toAFN_N(string postfix)
        {
            if (postfix == "")
            {
                NBresult = new AFN_N();
                NBresult.initialNode = new Node("q0");
                NBresult.initialNode.Link(_eps, new Node("qf", true));
                return;
            }
            Stack<AFN_N> afnStack = new Stack<AFN_N>();
            AFN_N temp, temp1, temp2;
            for (int i = 0; i < postfix.Length; i++)
            {
                char input = postfix[i];
                switch(input){
                    case '+':
                        temp = new AFN_N();
                        temp1 = afnStack.Pop();
                        temp.initialNode = new Node("q" + i);
                        temp.initialNode.Link(_eps, temp1.initialNode);
                        temp.nullOut.Add(temp.initialNode.Link(_eps, null));
                        temp1.Link(temp);
                        afnStack.Push(temp1);
                        break;
                    case '*':
                        temp = new AFN_N();
                        temp1 = afnStack.Pop();
                        temp.initialNode = new Node("q" + i);
                        temp.initialNode.Link(_eps,temp1.initialNode);
                        temp.nullOut.Add(temp.initialNode.Link(_eps, null));
                        temp1.Link(temp);
                        afnStack.Push(temp);
                        break;
                    case '&': //concatenation
                        temp1 = afnStack.Pop();
                        temp2 = afnStack.Pop();
                        temp2.Link(temp1);
                        afnStack.Push(temp2);
                        break;
                    case ',': //Or
                        temp = new AFN_N();
                        temp1 = afnStack.Pop();
                        temp2 = afnStack.Pop();
                        temp.initialNode = new Node("q" + i);
                        temp.initialNode.Link(_eps, temp2.initialNode);
                        temp.initialNode.Link(_eps, temp1.initialNode);
                        temp.joinNull(temp2.nullOut);
                        temp.joinNull(temp1.nullOut);
                        afnStack.Push(temp);
                        break;
                    default:
                        temp = new AFN_N();
                        temp.initialNode = new Node("q" + i);
                        temp.nullOut.Add(temp.initialNode.Link(input, null));
                        afnStack.Push(temp);
                        break;
                }
            }
            //add final state
            temp = afnStack.Pop();
            temp1 = new AFN_N();
            temp1.initialNode = new Node("qf", true);
            temp.Link(temp1);
            NBresult = temp;
        }
        public void computeAFN_E(string postfix){
            toAFN_N(postfix);
            toAFN_E(NBresult);
        }
    
    }
}
