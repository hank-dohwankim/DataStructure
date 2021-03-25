using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DataStructurePractice.Queue
{
    public class QueueInDotNetFramework
    {
        public void testQueue()
        {
            var queue = new ConcurrentQueue<int>();

            Task tEnq = Task.Factory.StartNew(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    queue.Enqueue(i);
                    Thread.Sleep(50);
                }
            });

            Task tDeq = Task.Factory.StartNew(() =>
            {
                int result;
                for (int i = 0; i < 100; i++)
                {
                    if(queue.TryDequeue(out result))
                    {
                        Console.WriteLine(result);
                        Thread.Sleep(100);
                    }
                }
            });

            Task.WaitAll(tEnq, tDeq);
        }
    }
}
