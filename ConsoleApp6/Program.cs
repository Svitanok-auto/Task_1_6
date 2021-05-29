using System;

namespace ConsoleApp6
{
    public static class Program
    {
        public const int MAX_ATTEMPTS = 10;
        public static void Main(string[] args)
        {
            Console.WriteLine("\nOrdinary Garland: ");
            OrdinaryGarland<Lamp> ordinaryGarland = new OrdinaryGarland<Lamp>();
            Console.WriteLine("\nColored Garland: ");
            ColoredGarland coloredGarland = new ColoredGarland();

            ReturnStateOfOrdinaryOrColoredGarland(ordinaryGarland, coloredGarland);

            Console.WriteLine("Work complete");
            Console.ReadKey();
        }

        public static void ReturnStateOfOrdinaryOrColoredGarland(OrdinaryGarland<Lamp> ordinaryGarland, ColoredGarland coloredGarland)
        {
            Validator validInput = new Validator();
            int attempt = 0;
            while (attempt < MAX_ATTEMPTS)
            {
                switch (validInput.GetChoiceToShowGarland())
                {
                    case 1:
                        ordinaryGarland.PrintTheListOfLampsInGarland(ordinaryGarland.ReturnCurrentStateOfLampsInGarland(ordinaryGarland.Lamps));
                        attempt++;
                        break;
                    case 2:
                        coloredGarland.PrintTheListOfLampsInColoredGarland(coloredGarland.ReturnCurrentStateOfLampsInGarland(coloredGarland.Lamps));
                        attempt++;
                        break;
                }
            }
        }
    }
}
