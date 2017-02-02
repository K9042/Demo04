using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teh1
{
    class Program
    {
        static void Main(string[] args)
        {
            Elevator elevator = new Elevator();

            do
            {
                Console.Write("Anna kerros jonne haluat mennä. Valitse 1-5 >");
                string syote = Console.ReadLine();
                elevator.Floor = int.Parse(syote);

                Console.WriteLine("Elevator is now in floor " + elevator.Floor);
            } while (1 == 1);
        }

    }
}
