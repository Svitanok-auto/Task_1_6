using System;
using System.Collections.Generic;

namespace ConsoleApp6
{
    public class ColoredGarland : Lamp
    {
        public Color Color { get; set; }
        public void PrintTheListOfLampsInGarland(List<ColoredGarland> lamps)
        {
            foreach (ColoredGarland lamp in lamps)
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
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine($"---ID: {lamp.ID}, Color:{lamp.Color}, State:{lamp.State}");
                }
            Console.ResetColor();
            }
        }

        public List<ColoredGarland> PopulateColoredGarland(int countOfLamps)
        {
            List<ColoredGarland> coloredLampList = new List<ColoredGarland>();
            for (int i = 0; i < countOfLamps; i++)
            {
                if ((i + 4 <= countOfLamps) && (4 <= countOfLamps))
                {
                    coloredLampList.Insert(i, new ColoredGarland { ID = i + 1, Color = Color.Red, State = (i + 1) % 2 == DateTime.Now.Minute % 2 ? State.On : State.Off });
                    coloredLampList.Insert(i + 1, new ColoredGarland { ID = i + 2, Color = Color.Yellow, State = (i + 2) % 2 == DateTime.Now.Minute % 2 ? State.On : State.Off });
                    coloredLampList.Insert(i + 2, new ColoredGarland { ID = i + 3, Color = Color.Green, State = (i + 3) % 2 == DateTime.Now.Minute % 2 ? State.On : State.Off });
                    coloredLampList.Insert(i + 3, new ColoredGarland { ID = i + 4, Color = Color.Blue, State = (i + 4) % 2 == DateTime.Now.Minute % 2 ? State.On : State.Off });
                    i = i + 3;
                }
                else if ((i + 2 < countOfLamps) && (4 < countOfLamps) && (countOfLamps % 4 != 0) && ((countOfLamps + 1) % 2 == 0))
                {
                    coloredLampList.Insert(i, new ColoredGarland { ID = i + 1, Color = Color.Red, State = (i + 1) % 2 == DateTime.Now.Minute % 2 ? State.On : State.Off });
                    coloredLampList.Insert(i + 1, new ColoredGarland { ID = i + 2, Color = Color.Yellow, State = (i + 2) % 2 == DateTime.Now.Minute % 2 ? State.On : State.Off });
                    coloredLampList.Insert(i + 2, new ColoredGarland { ID = i + 3, Color = Color.Green, State = (i + 3) % 2 == DateTime.Now.Minute % 2 ? State.On : State.Off });
                    i = i + 2;
                }
                else
                {
                    if ((i + 1 < countOfLamps) && (4 < countOfLamps) && (countOfLamps % 2 == 0) && ((countOfLamps + 2) % 4 == 0))
                    {
                        coloredLampList.Insert(i, new ColoredGarland { ID = i + 1, Color = Color.Red, State = (i + 1) % 2 == DateTime.Now.Minute % 2 ? State.On : State.Off });
                        coloredLampList.Insert(i + 1, new ColoredGarland { ID = i + 2, Color = Color.Yellow, State = (i + 2) % 2 == DateTime.Now.Minute % 2 ? State.On : State.Off });
                        i = i + 1;
                    }
                    else if ((i < countOfLamps) && (4 < countOfLamps) && ((countOfLamps % 5 == 0) || ((countOfLamps + 1) % 2 == 0)))
                    {
                        coloredLampList.Insert(i, new ColoredGarland { ID = i + 1, Color = Color.Red, State = (i + 3) % 2 == DateTime.Now.Minute % 2 ? State.On : State.Off });
                        i = i + 1;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
        return coloredLampList;
        }

        public override void ReturnCurrentStateOfLampsInGarland()
        {
            Validator validInput = new Validator();
            PrintTheListOfLampsInGarland(PopulateColoredGarland(validInput.GetCountOfLampsInGarland()));
        }
    }
}
