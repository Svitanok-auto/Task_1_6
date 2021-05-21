using System;
using System.Collections.Generic;

namespace ConsoleApp6
{
    public class OrdinaryGarland : Lamp
    {
        public void PrintTheListOfLampsInGarland(List<OrdinaryGarland> lamps)
        {
            foreach (OrdinaryGarland lamp in lamps)
            {
                if (lamp.State == State.On)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($"---ID: {lamp.ID}, State:{lamp.State}");
                }
                else if (lamp.State == State.Off)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine($"---ID: {lamp.ID}, State:{lamp.State}");
                }
            }
        }

        public List<OrdinaryGarland> PopulateOrdinaryGarland(int countOfLamps)
        {
            List<OrdinaryGarland> ordinaryLampList = new List<OrdinaryGarland>();
            for (int i = 0; i < countOfLamps; i++)
            {
                if ((i + 4 <= countOfLamps) && (4 <= countOfLamps))
                {
                    ordinaryLampList.Insert(i, new OrdinaryGarland { ID = i + 1, State = (i + 1) % 2 == DateTime.Now.Minute % 2 ? State.On : State.Off });
                    ordinaryLampList.Insert(i + 1, new OrdinaryGarland { ID = i + 2, State = (i + 2) % 2 == DateTime.Now.Minute % 2 ? State.On : State.Off });
                    ordinaryLampList.Insert(i + 2, new OrdinaryGarland { ID = i + 3, State = (i + 3) % 2 == DateTime.Now.Minute % 2 ? State.On : State.Off });
                    ordinaryLampList.Insert(i + 3, new OrdinaryGarland { ID = i + 4, State = (i + 4) % 2 == DateTime.Now.Minute % 2 ? State.On : State.Off });
                    i = i + 3;
                }
                else if ((i + 2 < countOfLamps) && (4 < countOfLamps) && (countOfLamps % 4 != 0) && ((countOfLamps + 1) % 2 == 0))
                {
                    ordinaryLampList.Insert(i, new OrdinaryGarland { ID = i + 1, State = (i + 1) % 2 == DateTime.Now.Minute % 2 ? State.On : State.Off });
                    ordinaryLampList.Insert(i + 1, new OrdinaryGarland { ID = i + 2, State = (i + 2) % 2 == DateTime.Now.Minute % 2 ? State.On : State.Off });
                    ordinaryLampList.Insert(i + 2, new OrdinaryGarland { ID = i + 3, State = (i + 3) % 2 == DateTime.Now.Minute % 2 ? State.On : State.Off });
                    i = i + 2;
                }
                else
                {
                    if ((i + 1 < countOfLamps) && (4 < countOfLamps) && (countOfLamps % 2 == 0) && ((countOfLamps + 2) % 4 == 0))
                    {
                        ordinaryLampList.Insert(i, new OrdinaryGarland { ID = i + 1, State = (i + 1) % 2 == DateTime.Now.Minute % 2 ? State.On : State.Off });
                        ordinaryLampList.Insert(i + 1, new OrdinaryGarland { ID = i + 2, State = (i + 2) % 2 == DateTime.Now.Minute % 2 ? State.On : State.Off });
                        i = i + 1;
                    }
                    else if ((i < countOfLamps) && (4 < countOfLamps) && ((countOfLamps % 5 == 0) || ((countOfLamps + 1) % 2 == 0)))
                    {
                        ordinaryLampList.Insert(i, new OrdinaryGarland { ID = i + 1, State = (i + 1) % 2 == DateTime.Now.Minute % 2 ? State.On : State.Off });
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

        public override void ReturnCurrentStateOfLampsInGarland()
        {
            Validator validInput = new Validator();
                PrintTheListOfLampsInGarland(PopulateOrdinaryGarland(validInput.GetCountOfLampsInGarland()));
        }
    }
}
