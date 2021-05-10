using System;

namespace ConsoleApp6
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ColoredLamp coloredGarland = new ColoredLamp();
            coloredGarland.ReturnCurrentStateOfGarland();

            OrdinaryLamp ordinaryGarland = new OrdinaryLamp();
            ordinaryGarland.ReturnCurrentStateOfGarland();

            Console.ReadKey();
        }
    }
}
