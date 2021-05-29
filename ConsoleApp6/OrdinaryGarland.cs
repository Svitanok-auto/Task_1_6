using System;
using System.Collections.Generic;

namespace ConsoleApp6
{
    public class OrdinaryGarland<T> where T : Lamp,  new()
    {
        public List<T> Lamps { get; set; }

        public OrdinaryGarland()
        {
            Validator validInput = new Validator();
            int numberOfLamps = validInput.GetCountOfLampsInGarland();
            Lamps = new List<T>();
            for (int i = 1; i < numberOfLamps +1; i++)
            {
                Lamps.Insert(i - 1, new T { ID = i });
            }
        }

        public void PrintTheListOfLampsInGarland(List<Lamp> lamps)
        {
            foreach (Lamp lamp in lamps)
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
        Console.ResetColor();
        }

        public virtual List<T> ReturnCurrentStateOfLampsInGarland(List<T> lamps)
        {
            foreach (T lamp in lamps)
            {
                lamp.State = lamp.ID % 2 == DateTime.Now.Minute % 2 ? State.On : State.Off;
            }
        return lamps;
        }
    }
}
    