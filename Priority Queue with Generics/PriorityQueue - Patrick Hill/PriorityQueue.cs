using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriorityQueue___Patrick_Hill
{
    public class PriorityQueue<T>
    {
        //A struct to hold each of our priority/item pairs.
        //Item is of type "T":
        public struct PQNode
        {
            public int Priority;
            public T Item;
        }

        //Internal List collection to hold our nodes
        //only one field variable:
        private List<PQNode> nodeList = new List<PQNode>(); //Generic List

        //Add a node to the queue.
        //Returns true if the node was successfully
        //added and false if not (duplicate or invalid
        //priority or item):
        public bool Enqueue(PQNode newNode)
        {
            if (object.Equals(newNode.Item, default(T)) || (newNode.Priority <= 0))
            {
                return false;
            }

            foreach (PQNode wpqNode in nodeList)
            {
                if ((wpqNode.Priority == newNode.Priority) || object.Equals(wpqNode.Item, newNode.Item))
                {
                    return false;
                }
            }

            //Operation was Successful
            //Add new node to the list
            nodeList.Add(newNode);
            return true;
        }

        //Return a node to be deleted from the queue and
        //then delete it. If the queue is empty,
        //the node priority will be zero:
        public PQNode Dequeue()
        {
            PQNode wpqNode = FindMaxNode();

            if (wpqNode.Priority == 0)
            {
                return wpqNode;
            }

            //Successfully remove Node
            nodeList.Remove(wpqNode);
            return wpqNode;
        }

        //Indexer to allow index access to any node:
        public PQNode this[int i]
        {
            get
            {
                return nodeList[i];
            }
        }


        //Returns the next node that would be dequeued
        //without actually removing it.  If the queue
        //is empty, the node priority will be zero:
        public PQNode Peek()
        {
            PQNode wpqNode = FindMaxNode();
            return wpqNode;
        }

        //Empty the queue:
        public void Clear()
        {
            nodeList.Clear();
        }

        //Return the number of nodes in the queue:
        public int Count
        {
            get
            {
                return nodeList.Count;
            }
        }

        //Used internally by Dequeue and Peek
        //to find maximum numerical priority node:
        private PQNode FindMaxNode()
        {
            int maxPriority = -1;
            int targetIndex = -1;

            PQNode wpqNode = new PQNode();

            if (nodeList.Count == 0)
            {
                return wpqNode;
            }

            for (int i = 0; i < nodeList.Count; i++)
            {
                if (nodeList[i].Priority > maxPriority)
                {
                    maxPriority = nodeList[i].Priority;
                    targetIndex = i;
                }
            }
            wpqNode = nodeList[targetIndex];
            return wpqNode;
        }
    }
}
