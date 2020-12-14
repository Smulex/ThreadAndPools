using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Thermometer thermometer = new Thermometer();
            Thread thermometerThread = new Thread(new ThreadStart(thermometer.Alarm));
            thermometerThread.Start();
            while (true)
            {
                if (!thermometerThread.IsAlive)
                {
                    Console.WriteLine("Alarm-tråd termineret!");
                    break;
                }
                Thread.Sleep(10000);
            }
        }
    }
    class Thermometer
    {

        public void Alarm()
        {
            int alarmCounter = 0;
            while (alarmCounter < 3)
            {
                int temperature = RandomNumber(-20, 120);
                Console.WriteLine("Temprature = " + temperature);
                if (temperature <= 0 || temperature >= 100)
                {
                    Console.WriteLine("Alarm");
                    alarmCounter++;
                }
                Thread.Sleep(100);
            }
        }

        public int RandomNumber(int startNumbe, int endNumber)
        {
            Random generator = new Random();
            int temperature = generator.Next(startNumbe, endNumber);
            return temperature;
        }
    }
}
