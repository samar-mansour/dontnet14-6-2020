using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopHW_1406
{
    [DebuggerDisplay("{model} {(price * 3.67)}$")]
    public class Computer
    {
        public string model;
        public int price;
        public int numberOfProcessors;
        public float screenSize;
        public bool isTurnOn;

        public void tellMeThePrice()
        {
            Console.WriteLine($"price {model}: {price}");
        }

        public void tellMeTheScreenSize()
        {
            Console.WriteLine($"{model} screen size: {screenSize}");
        }

        public void turnOn()
        {
            Console.WriteLine($"The divice is on...");
            isTurnOn = true;
        }

        public void turnOff()
        {
            Console.WriteLine($"The divice is off...");
            isTurnOn = false;
        }

        public void addProcessor()
        {
            Console.WriteLine("another processor");
            numberOfProcessors++;
        }

        public override string ToString()
        {
            return $"[Computer]: model: {model} Price: {price} Processor number: {numberOfProcessors} Screen Size: {screenSize} isTurnOn: {isTurnOn} ";
        }
    }
}
