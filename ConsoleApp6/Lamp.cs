using System;

namespace ConsoleApp6
{
    public abstract class Lamp
    {
        public int ID { get; set; }
        public State State { get; set; }
        public abstract void ReturnCurrentStateOfLampsInGarland();
    }
}
