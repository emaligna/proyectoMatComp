﻿using System;
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
        public override string ToString()
        {
            return input+"-"+destination;
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
        public Transition Link(char input, Node destination)
        {
            Transition trans = new Transition(input, destination);
            transitions.Add(trans);
            return trans;
        }
        public override string ToString()
        {
            return this.name;
        }



        
    }
}
