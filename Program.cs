using System;
using System.Collections;
using System.Collections.Generic;


namespace Homework13112564
{
    class Queue
    {
        private Node Root;

        public void Push(Node node)
        {
            if (Root == null)
            {
                Root = node;
            }
            else
            {
                Node ptr = Root;
                while (ptr.Next != null)
                {
                    ptr = ptr.Next;
                }
                ptr.Next = node;
            }
        }

        public Node Pop()
        {
            if (Root == null)
            {
                return null;
            }
            Node node = Root;
            Root = Root.Next;
            node.Next = null;
            return node;
        }


    }

    class Node
    {
        public string instruction;
        public string data;
        public Node Next;
        public Node(string instructionvalue, string datavalue)
        {
            instruction = instructionvalue;
            data = datavalue;
            Next = null;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            string[] input = new string[2];
            Queue queue = new Queue();
            Node Inputinfo;
            int count = 0;
            int i=0;


            while (true)
            {
                input[i] =Console.ReadLine();
                if (input[0] == "?")
                {
                    break;
                }
                Inputinfo = new Node(input[0], input[1]);
                queue.Push(Inputinfo);
            }


            
        }    
        
    }
   
}
   


