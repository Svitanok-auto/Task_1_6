using System;
using System.Collections.Generic;

namespace ConsoleApp6
{
    public class ColoredLamp : Garland
    {
        public const string COLOR_RED = "Red";
        public const string COLOR_YELLOW = "Yellow";
        public const string COLOR_BLUE = "Blue";
        public const string COLOR_GREEN = "Green";
        public string Color { get; set; }

        public void PrintTheListOfLampsInGarland(List<ColoredLamp> lamps)
        {
            foreach (ColoredLamp lamp in lamps)
            {
                Console.WriteLine($"---ID: {lamp.ID}, Color:{lamp.Color}, State:{lamp.State}");
            }
        }

        public List<ColoredLamp> PopulateColoredGarlandOnEvenMinute(int countOfLamps)
        {
            List<ColoredLamp> coloredLampList = new List<ColoredLamp>();
            for (int i = 0; i < countOfLamps; i++)
            {
                if ((i + 4 <= countOfLamps) && (4 <= countOfLamps))
                {
                    coloredLampList.Insert(i, new ColoredLamp { ID = i + 1, Color = COLOR_RED, State = STATE_OFF });
                    coloredLampList.Insert(i + 1, new ColoredLamp { ID = i + 2, Color = COLOR_YELLOW, State = STATE_ON });
                    coloredLampList.Insert(i + 2, new ColoredLamp { ID = i + 3, Color = COLOR_GREEN, State = STATE_OFF });
                    coloredLampList.Insert(i + 3, new ColoredLamp { ID = i + 4, Color = COLOR_BLUE, State = STATE_ON });
                    i = i + 3;
                }
                else if ((i + 2 < countOfLamps) && (4 < countOfLamps) && (countOfLamps % 4 != 0) && ((countOfLamps + 1) % 2 == 0))
                {
                    coloredLampList.Insert(i, new ColoredLamp { ID = i + 1, Color = COLOR_RED, State = STATE_OFF });
                    coloredLampList.Insert(i + 1, new ColoredLamp { ID = i + 2, Color = COLOR_YELLOW, State = STATE_ON });
                    coloredLampList.Insert(i + 2, new ColoredLamp { ID = i + 3, Color = COLOR_GREEN, State = STATE_OFF });
                    i = i + 2;
                }
                else
                {
                    if ((i + 1 < countOfLamps) && (4 < countOfLamps) && (countOfLamps % 2 == 0) && ((countOfLamps + 2) % 4 == 0))
                    {
                        coloredLampList.Insert(i, new ColoredLamp { ID = i + 1, Color = COLOR_RED, State = STATE_OFF });
                        coloredLampList.Insert(i + 1, new ColoredLamp { ID = i + 2, Color = COLOR_YELLOW, State = STATE_ON });
                        i = i + 1;
                    }
                    else if ((i < countOfLamps) && (4 < countOfLamps) && ((countOfLamps % 5 == 0) || ((countOfLamps + 1) % 2 == 0)))
                    {
                        coloredLampList.Insert(i, new ColoredLamp { ID = i + 1, Color = COLOR_RED, State = STATE_OFF });
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

        public List<ColoredLamp> PopulateColoredGarlandOnOddMinute(int countOfLamps)
        {
            List<ColoredLamp> coloredLampList = new List<ColoredLamp>();
            for (int i = 0; i < countOfLamps; i++)
            {
                if ((i + 4 <= countOfLamps) && (4 <= countOfLamps))
                {
                    coloredLampList.Insert(i, new ColoredLamp { ID = i + 1, Color = COLOR_RED, State = STATE_ON });
                    coloredLampList.Insert(i + 1, new ColoredLamp { ID = i + 2, Color = COLOR_YELLOW, State = STATE_OFF });
                    coloredLampList.Insert(i + 2, new ColoredLamp { ID = i + 3, Color = COLOR_GREEN, State = STATE_ON });
                    coloredLampList.Insert(i + 3, new ColoredLamp { ID = i + 4, Color = COLOR_BLUE, State = STATE_OFF });
                    i = i + 3;
                }
                else if ((i + 2 < countOfLamps) && (4 < countOfLamps) && (countOfLamps % 4 != 0) && ((countOfLamps + 1) % 2 == 0))
                {
                    coloredLampList.Insert(i, new ColoredLamp { ID = i + 1, Color = COLOR_RED, State = STATE_ON });
                    coloredLampList.Insert(i + 1, new ColoredLamp { ID = i + 2, Color = COLOR_YELLOW, State = STATE_OFF });
                    coloredLampList.Insert(i + 2, new ColoredLamp { ID = i + 3, Color = COLOR_GREEN, State = STATE_ON });
                    i = i + 2;
                }
                else
                {
                    if ((i + 1 < countOfLamps) && (4 < countOfLamps) && (countOfLamps % 2 == 0) && ((countOfLamps + 2) % 4 == 0))
                    {
                        coloredLampList.Insert(i, new ColoredLamp { ID = i + 1, Color = COLOR_RED, State = STATE_ON });
                        coloredLampList.Insert(i + 1, new ColoredLamp { ID = i + 2, Color = COLOR_YELLOW, State = STATE_OFF });
                        i = i + 1;
                    }
                    else if ((i < countOfLamps) && (4 < countOfLamps) && ((countOfLamps % 5 == 0) || ((countOfLamps + 1) % 2 == 0)))
                    {
                        coloredLampList.Insert(i, new ColoredLamp { ID = i + 1, Color = COLOR_RED, State = STATE_ON });
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

        public override void ReturnCurrentStateOfGarland()
        {
            Validator validInput = new Validator();
            if (GetIfCurrentMinuteIsEven())
            {
                PrintTheListOfLampsInGarland(PopulateColoredGarlandOnEvenMinute(validInput.GetCountOfLampsInGarland()));
            }
            else
            {
                PrintTheListOfLampsInGarland(PopulateColoredGarlandOnOddMinute(validInput.GetCountOfLampsInGarland()));
            }
        }
    }
}
