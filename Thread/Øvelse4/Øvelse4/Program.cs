using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Øvelse4
{
    class InputOutput
    {
        char input = '*';
        public void Printer()
        {
            while (true)
            {
                Console.Write(input);
                Thread.Sleep(1);
            }
        }

        public void Reader()
        {
            while (true)
            {
                try
                {
                    char readCharacter = Convert.ToChar(Console.ReadLine());
                    input = readCharacter;
                }
                catch (Exception)
                {
                    throw;
                }

            }
        }
    }

    class Program
    {


        static void Main(string[] args)
        {
            InputOutput inputOutput = new InputOutput();

            Thread threadPrinter = new Thread(new ThreadStart(inputOutput.Printer));
            threadPrinter.Start();

            Thread threadReader = new Thread(new ThreadStart(inputOutput.Reader));
            threadReader.Start();

            threadReader.Join();
            Console.ReadKey();
        }
    }
}
