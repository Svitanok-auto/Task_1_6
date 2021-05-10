using System;
using System.Collections.Generic;

namespace ConsoleApp6
{
    public class OrdinaryLamp : Garland
    {
        public void PrintTheListOfLampsInGarland(List<OrdinaryLamp> lamps)
        {
            foreach (OrdinaryLamp lamp in lamps)
            {
                Console.WriteLine($"---ID: {lamp.ID}, State:{lamp.State}");
            }
        }

        public List<OrdinaryLamp> PopulateOrdinaryGarlandOnEvenMinute(int countOfLamps)
        {
            List<OrdinaryLamp> ordinaryLampList = new List<OrdinaryLamp>();
            for (int i = 0; i < countOfLamps; i++)
            {
                if ((i + 4 <= countOfLamps) && (4 <= countOfLamps))
                {
                    ordinaryLampList.Insert(i, new OrdinaryLamp { ID = i + 1, State = STATE_OFF });
                    ordinaryLampList.Insert(i + 1, new OrdinaryLamp { ID = i + 2, State = STATE_ON });
                    ordinaryLampList.Insert(i + 2, new OrdinaryLamp { ID = i + 3, State = STATE_OFF });
                    ordinaryLampList.Insert(i + 3, new OrdinaryLamp { ID = i + 4, State = STATE_ON });
                    i = i + 3;
                }
                else if ((i + 2 < countOfLamps) && (4 < countOfLamps) && (countOfLamps % 4 != 0) && ((countOfLamps + 1) % 2 == 0))
                {
                    ordinaryLampList.Insert(i, new OrdinaryLamp { ID = i + 1, State = STATE_OFF });
                    ordinaryLampList.Insert(i + 1, new OrdinaryLamp { ID = i + 2, State = STATE_ON });
                    ordinaryLampList.Insert(i + 2, new OrdinaryLamp { ID = i + 3, State = STATE_OFF });
                    i = i + 2;
                }
                else
                {
                    if ((i + 1 < countOfLamps) && (4 < countOfLamps) && (countOfLamps % 2 == 0) && ((countOfLamps + 2) % 4 == 0))
                    {
                        ordinaryLampList.Insert(i, new OrdinaryLamp { ID = i + 1, State = STATE_OFF });
                        ordinaryLampList.Insert(i + 1, new OrdinaryLamp { ID = i + 2, State = STATE_ON });
                        i = i + 1;
                    }
                    else if ((i < countOfLamps) && (4 < countOfLamps) && ((countOfLamps % 5 == 0) || ((countOfLamps + 1) % 2 == 0)))
                    {
                        ordinaryLampList.Insert(i, new OrdinaryLamp { ID = i + 1, State = STATE_OFF });
                        i = i + 1;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            return ordinaryLampList;
        }

        public List<OrdinaryLamp> PopulateOrdinaryGarlandOnOddMinute(int countOfLamps)
        {
            List<OrdinaryLamp> ordinaryLampList = new List<OrdinaryLamp>();
            for (int i = 0; i < countOfLamps; i++)
            {
                if ((i + 4 <= countOfLamps) && (4 <= countOfLamps))
                {
                    ordinaryLampList.Insert(i, new OrdinaryLamp { ID = i + 1, State = STATE_ON });
                    ordinaryLampList.Insert(i + 1, new OrdinaryLamp { ID = i + 2, State = STATE_OFF });
                    ordinaryLampList.Insert(i + 2, new OrdinaryLamp { ID = i + 3, State = STATE_ON });
                    ordinaryLampList.Insert(i + 3, new OrdinaryLamp { ID = i + 4, State = STATE_OFF });
                    i = i + 3;
                }
                else if ((i + 2 < countOfLamps) && (4 < countOfLamps) && (countOfLamps % 4 != 0) && ((countOfLamps + 1) % 2 == 0))
                {
                    ordinaryLampList.Insert(i, new OrdinaryLamp { ID = i + 1, State = STATE_ON });
                    ordinaryLampList.Insert(i + 1, new OrdinaryLamp { ID = i + 2, State = STATE_OFF });
                    ordinaryLampList.Insert(i + 2, new OrdinaryLamp { ID = i + 3, State = STATE_ON });
                    i = i + 2;
                }
                else
                {
                    if ((i + 1 < countOfLamps) && (4 < countOfLamps) && (countOfLamps % 2 == 0) && ((countOfLamps + 2) % 4 == 0))
                    {
                        ordinaryLampList.Insert(i, new OrdinaryLamp { ID = i + 1, State = STATE_ON });
                        ordinaryLampList.Insert(i + 1, new OrdinaryLamp { ID = i + 2, State = STATE_OFF });
                        i = i + 1;
                    }
                    else if ((i < countOfLamps) && (4 < countOfLamps) && ((countOfLamps % 5 == 0) || ((countOfLamps + 1) % 2 == 0)))
                    {
                        ordinaryLampList.Insert(i, new OrdinaryLamp { ID = i + 1, State = STATE_ON });
                        i = i + 1;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            return ordinaryLampList;
        }

        public override void ReturnCurrentStateOfGarland()
        {
            Validator validInput = new Validator();
            if (GetIfCurrentMinuteIsEven())
            {
                PrintTheListOfLampsInGarland(PopulateOrdinaryGarlandOnEvenMinute(validInput.GetCountOfLampsInGarland()));
            }
            else
            {
                PrintTheListOfLampsInGarland(PopulateOrdinaryGarlandOnOddMinute(validInput.GetCountOfLampsInGarland()));
            }
        }
    }
}
