using System;

namespace Lib.MementoPattern
{
    public class Memento
    {
        public Memento(string state)
        {
            State = state;
        }

        public string State { get; set; }
    }
}
