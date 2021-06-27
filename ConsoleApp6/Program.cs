using System;

namespace ConsoleApp6
{
    public static class Program
    {
        public const int MAX_ATTEMPTS = 10;
        public static void Main(string[] args)
        {
            Console.WriteLine("\nOrdinary Garland: ");
            Garland<Lamp> ordinaryGarland = new Garland<Lamp>();
            Console.WriteLine("\nColored Garland: ");
            ColoredGarland coloredGarland = new ColoredGarland();

            Validator validInput = new Validator();
            int attempt = 0;
            while ((attempt < MAX_ATTEMPTS))
            {
                switch (validInput.GetChoiceToShowGarland())
                {
                    case 1:
                        ordinaryGarland.PrintTheListOfLampsInGarland(ordinaryGarland.ReturnCurrentStateOfLampsInGarland(ordinaryGarland.Lamps));
                        attempt++;
                        break;
                    case 2:
                        coloredGarland.PrintTheListOfLampsInGarland(coloredGarland.ReturnCurrentStateOfLampsInGarland(coloredGarland.Lamps));
                        attempt++;
                        break;
                    case 3:
                        Console.WriteLine("Work complete");
                        return;
                }
            }
            Console.ReadKey();
        }
    }
}
