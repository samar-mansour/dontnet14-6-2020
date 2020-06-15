using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopHW_1406
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer asus = new Computer()
            {
                model = "ROG",
                price = 6459,
                numberOfProcessors = 1,
                screenSize = 15.7f,
                isTurnOn = true
            };

            Computer lenovo = new Computer()
            {
                model = "Z51",
                price = 8759,
                numberOfProcessors = 0,
                screenSize = 17.8f,
                isTurnOn = false
            };

            Computer corsair = new Computer()
            {
                model = "One i160",
                price = 3562,
                numberOfProcessors = 2,
                screenSize = 15.7f,
                isTurnOn = false
            };

            Console.WriteLine(asus);

            asus.tellMeThePrice();
            asus.tellMeTheScreenSize();
            asus.turnOn();
            asus.addProcessor();

        }
    }
}
