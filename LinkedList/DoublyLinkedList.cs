using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructurePractice.LinkedList
{
    class DoublyLinkedList<T>
    {
        private DoublyLinkedListNode<T> head;

        public void Add(DoublyLinkedListNode<T> newNode)
        {
            if (head == null) // if list is empty
            {
                head = newNode;
            }
            else
            {
                var current = head;
                while (current != null && current.Next != null)
                {
                    current = current.Next;
                }

                // connect both side node
                current.Next = newNode;
                newNode.Prev = current;
                newNode.Next = null;
            }
        }

        public void AddAfter(DoublyLinkedListNode<T> current, DoublyLinkedListNode<T> newNode)
        {
            if (head == null || current == null || newNode == null)
            {
                throw new InvalidOperationException();
            }

            newNode.Next = current.Next;
            current.Next.Prev = newNode;
            newNode.Prev = current;
            current.Next = newNode;
        }

        public void Remove(DoublyLinkedListNode<T> removeNode)
        {
            if (head == null || removeNode == null)
            {
                return;
            }

            if(removeNode == head)
            {
                head = head.Next;
                if(head != null)
                {
                    head.Prev = null;
                }
            }
            else
            {
                removeNode.Prev.Next = removeNode.Next;
          
                if(removeNode.Next != null)
                {
                    removeNode.Next.Prev = removeNode.Prev;
                }
            }
            removeNode = null;
        }

        public DoublyLinkedListNode<T> GetNode(int index)
        {
            var current = head;
            for(int i =0; i<index && current != null; i++)
            {
                current = current.Next;
            }

            // Return null if index greater than list count
            return current;
        }

        public int Count()
        {
            int count = 0;

            var current = head;

            while (current != null)
            {
                count++;
                current = current.Next;
            }

            return count;
        }
    }
}
