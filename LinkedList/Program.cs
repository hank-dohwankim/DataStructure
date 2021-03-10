using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            // create integer type singly linked list
            var list = new SinglyLinkedList<int>();

            // add 0~4 to list
            for (int i = 0; i < 5; i++)
            {
                list.Add(new SinglyLinkedListNode<int>(i));
            }

            // delete node index 2
            var node = list.GetNode(2);
            list.Remove(node);

            // get node index 1
            node = list.GetNode(1);

            // append node value 100 after index 1 node
            list.AddAfter(node, new SinglyLinkedListNode<int>(100));

            // check list count
            int count = list.Count();

            // print all nodes in list
            for (int i = 0; i < count; i++)
            {
                var n = list.GetNode(i);
                Console.WriteLine(n.Data);
            }
        }
    }
}
