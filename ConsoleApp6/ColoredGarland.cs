using System;
using System.Collections.Generic;

namespace ConsoleApp6
{
    public class ColoredGarland : OrdinaryGarland<ColoredLamp>
    {
        public ColoredGarland() : base()
        {
            int index = 0;
            foreach (Lamp lamp in Lamps)
            {
                    index += 1;
                    int caseSwitch = (index + 1) % 4;
                    switch (caseSwitch)
                    {
                        case 0:
                            Lamps[index - 1].Color = Color.Green;
                            break;
                        case 1:
                            Lamps[index - 1].Color = Color.Blue;
                            break;
                        case 2:
                            Lamps[index - 1].Color = Color.Red;
                            break;
                        case 3:
                            Lamps[index - 1].Color = Color.Yellow;
                            break;
                    }      
            }
        }

        public void PrintTheListOfLampsInColoredGarland(List<ColoredLamp> lamps)
        {
            foreach (ColoredLamp lamp in lamps)
            {
                if ((lamp.Color == Color.Red) && (lamp.State == State.On))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"---ID: {lamp.ID}, Color:{lamp.Color}, State:{lamp.State}");
                }
                if ((lamp.Color == Color.Yellow) && (lamp.State == State.On))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"---ID: {lamp.ID}, Color:{lamp.Color}, State:{lamp.State}");
                }
                if ((lamp.Color == Color.Green) && (lamp.State == State.On))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"---ID: {lamp.ID}, Color:{lamp.Color}, State:{lamp.State}");
                }
                if ((lamp.Color == Color.Blue) && (lamp.State == State.On))
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"---ID: {lamp.ID}, Color:{lamp.Color}, State:{lamp.State}");
                }
                else if (lamp.State == State.Off)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine($"---ID: {lamp.ID}, Color:{lamp.Color}, State:{lamp.State}");
                }
            Console.ResetColor();
            }
        }
    }
}