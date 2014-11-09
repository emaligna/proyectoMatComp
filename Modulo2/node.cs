using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo2
{
    class Transition
    {
         public Node destination;
            public char input;
            public Transition(char input, Node destination)
            {
                this.input = input;
                this.destination = destination;
            }
    }
    class Node
    {
        public string name;
        public bool final;
        public List<Transition> transitions = new List<Transition>();
        
        public Node(string name,bool final=false)
        {
            this.name = name;
            this.final = final;
        }
        public void Link(char input, Node destination)
        {
            transitions.Add(new Transition(input, destination));
        }



        
    }
}
