﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructurePractice.Queue
{
    public class QueueUsingCircularArray
    {
        private object[] a;
        private int front;
        private int rear;

        public QueueUsingCircularArray(int queueSize)
        {
            a = new object[queueSize];
            front = -1;
            rear = -1;
        }

        public void Enqueue(object data)
        {
            if ((rear + 1) % a.Length == front)
            {
                throw new ApplicationException("Full");
            }
            else
            {
                if (front == -1)
                {
                    front++;
                }
                rear = (rear + 1) % a.Length;
                a[rear] = data;
            }    
        }

        public object Dequeue()
        {
            if(front == -1 && rear == -1)
            {
                throw new ApplicationException("Empty");
            }
            else
            {
                object data = a[front];

                if(front == rear)
                {
                    front = -1;
                    rear = -1;
                }
                else
                {
                    front = (front + 1) % a.Length;
                }

                return data;
            }
        }
    }
}
