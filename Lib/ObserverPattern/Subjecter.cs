using System;
using System.Collections.Generic;

namespace Lib.ObserverPattern
{
    public class Subjecter
    {
        private List<Observer> observers = new List<Observer>();
        public int State {
            get{return this.State;}
            set{
            this.State = value;
        }}

        public void Attach(Observer observer)
        {
            observers.Add(observer);
        }

        public void NotifyObservers()
        {
            foreach(var observer in observers)
            {
                observer.Update();
            }
        }
    }
}
