using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Simple_Thread
{
    //Øvelse 0, 1 og 2
    class Program
    {
        public void Øvelse1()
        {
            Thread thread3 = new Thread(Thread3);
            thread3.Start();
            Thread thread4 = new Thread(Thread4);
            thread4.Start();
        }
        public void Thread3()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("C#-trådning er nemt!");
            }
        }
        public void Thread4()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Også med flere tråde …!");
            }
        }

        public void WorkThreadFunction()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Simple Thread");
                Thread thread1 = new Thread(new ThreadStart(Thread1))
                {
                    Name = "Thread1"
                };
                thread1.Start();
                thread1.Join();
                Console.WriteLine(thread1.Name);

                Thread thread2 = new Thread(new ThreadStart(Thread2))
                {
                    Name = "Thread2"
                };
                thread2.Start();
                thread2.Join();
                Console.WriteLine(thread2.Name);
            }
        }

        public void Thread1()
        {
            Console.WriteLine("Thread1");
        }

        public void Thread2()
        {
            Console.WriteLine("Thread2");
        }
    }

    class Threprog
    {
        public static void Main()
        {
            Program pg = new Program();
            Thread thread = new Thread(new ThreadStart(pg.WorkThreadFunction));
            thread.Start();
            Console.Read();
        }
    }
}