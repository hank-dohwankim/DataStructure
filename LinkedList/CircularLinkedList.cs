using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructurePractice.LinkedList
{
    public class CircularLinkedList<T>
    {
        private DoublyLinkedListNode<T> head;

        public void Add(DoublyLinkedListNode<T> newNode)
        {
            if (head == null) // if list is empty
            {
                head = newNode;
                head.Next = head;
                head.Prev = head;
            }
            else
            {
                var tail = head.Prev;

                head.Prev = newNode;
                tail.Next = newNode;
                newNode.Prev = tail;
                newNode.Next = head;
            }
        }

        public void AddAfter(DoublyLinkedListNode<T> current, DoublyLinkedListNode<T> newNode)
        {
            if(head == null || current == null || newNode == null)
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
            if(head == null || removeNode == null)
            {
                return;
            }

            if(removeNode == head && head == head.Next)
            {
                head = null;
            }
            else
            {
                removeNode.Prev.Next = removeNode.Next;
                removeNode.Next.Prev = removeNode.Prev; 
            }

            removeNode = null;
        }

        public DoublyLinkedListNode<T> GetNode(int index)
        {
            if(head == null)
            {
                return null;
            }

            int count = 0;
            var current = head;
            while(count < index)
            {
                current = current.Next;
                count++;
                if(current == head)
                {
                    return null;
                }
            }
            return current;
        }

        public int Count()
        {
            if (head == null) return 0;
            int count = 0;
            var current = head;
            do
            {
                count++;
                current = current.Next;
            } while (current != head);

            return count;
        }
    }
}
