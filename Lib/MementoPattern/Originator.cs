using System;

namespace Lib.MementoPattern
{
    public class Originator
    {
        public string State { get; set; }

        public Memento SaveStateToMemnto()
        {
            return new Memento(State);
        }

        public void GetStateFromMemento(Memento memento)
        {
            State = memento.State;
        }
    }
}
