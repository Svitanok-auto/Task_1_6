using System;

namespace ConsoleApp6
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Colored Garland: ");
            ColoredGarland coloredGarland = new ColoredGarland();
            coloredGarland.ReturnCurrentStateOfLampsInGarland();

            Console.WriteLine("\nOrdinary Garland: ");
            OrdinaryGarland ordinaryGarland = new OrdinaryGarland();
            ordinaryGarland.ReturnCurrentStateOfLampsInGarland();

            Console.ReadKey();
        }
    }
}
