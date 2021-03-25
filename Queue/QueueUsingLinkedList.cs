﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructurePractice.Queue
{
    public class QueueUsingLinkedList
    {
        private Node head = null;
        private Node tail = null;

        public void Enqueue(object data)
        {
            if(head == null)
            {
                head = new Node(data);
                tail = head;
            }
            else
            {
                tail.Next = new Node(data);
                tail = tail.Next;
            }
        }

        public object Dequeue()
        {
            if(head == null)
            {
                throw new ApplicationException("Empty");
            }

            object data = head.Data;

            if (head == tail)
            {
                head = tail = null;
            }
            else
            {
                head = head.Next;
            }

            return data;
        }
    }
}
