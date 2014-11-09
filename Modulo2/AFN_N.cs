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
        public Node initialNode;
        public List<Node> FreeNodes;
        public AFN_N()
        {
            initialNode = null;
            FreeNodes = new List<Node>();
        }
        public void Link(AFN_N afn)
        {
            for (int i = 0; i < FreeNodes.Count; i++) 
                for (int j = 0; j < FreeNodes[i].transitions.Count; j++)
                    if (FreeNodes[i].transitions[j].destination == null)
                        FreeNodes[i].transitions[j].destination = afn.initialNode;
            FreeNodes = afn.FreeNodes;
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
