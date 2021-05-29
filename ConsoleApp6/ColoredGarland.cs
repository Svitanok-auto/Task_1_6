using System;
using System.Collections.Generic;

namespace ConsoleApp6
{
    public class ColoredGarland : OrdinaryGarland<ColoredLamp>
    {
        public ColoredGarland() : base()
        {
            for (int i = 0; i < Lamps.Count; i++)
            {
                if ((i + 4 <= Lamps.Count) && (4 <= Lamps.Count))
                {
                    Lamps[i].Color = Color.Red;
                    Lamps[i + 1].Color = Color.Yellow;
                    Lamps[i + 2].Color = Color.Green;
                    Lamps[i + 3].Color = Color.Blue;
                    i = i + 3;
                }
                else if ((i + 2 < Lamps.Count) && (4 < Lamps.Count) && (Lamps.Count % 4 != 0) && ((Lamps.Count + 1) % 2 == 0))
                {
                    Lamps[i].Color = Color.Red;
                    Lamps[i + 1].Color = Color.Yellow;
                    Lamps[i + 2].Color = Color.Green;
                    i = i + 2;
                }
                else
                {
                    if ((i + 1 < Lamps.Count) && (4 < Lamps.Count) && (Lamps.Count % 2 == 0) && ((Lamps.Count + 2) % 4 == 0))
                    {
                        Lamps[i].Color = Color.Red;
                        Lamps[i + 1].Color = Color.Yellow;
                        i = i + 1;
                    }
                    else if ((i < Lamps.Count) && (4 < Lamps.Count) && ((Lamps.Count % 5 == 0) || ((Lamps.Count + 1) % 2 == 0)))
                    {
                        Lamps[i].Color = Color.Red;
                        i = i + 1;
                    }
                    else
                    {
                        continue;
                    }
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