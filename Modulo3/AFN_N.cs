using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo3
{
    // Node based AFN-ε.
    class AFN_N
    {
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
    }
        
}
