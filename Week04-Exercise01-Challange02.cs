using System;
using System.Threading;

enum TrafficLight { Red, Yellow, Green }

class Program
{
    static void Main()
    {
        while (true)
        {
            foreach (TrafficLight light in Enum.GetValues(typeof(TrafficLight)))
            {
                Console.WriteLine($"\nCurrent light: {light}");

                if (light == TrafficLight.Red)
                    Console.WriteLine("STOP! Pedestrians may cross.");
                else if (light == TrafficLight.Yellow)
                    Console.WriteLine("Prepare to stop. Pedestrians wait.");
                else
                    Console.WriteLine("GO! Pedestrians must wait.");

                Thread.Sleep(2000);
            }
        }
    }
}