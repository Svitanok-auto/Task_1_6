using System;

namespace ConsoleApp6
{
    public abstract class Garland
    {
        public const string STATE_ON = "On";
        public const string STATE_OFF= "Off";
        public int ID { get; set; }
        public string State { get; set; }
        public abstract void ReturnCurrentStateOfGarland();

        public bool GetIfCurrentMinuteIsEven()
        {
            DateTime localDate = DateTime.Now;
            Console.WriteLine("\nCurrent minute is " + localDate.Minute);
            if ((localDate.Minute % 2 == 0) || (localDate.Minute == 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
