using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using BrickInvaders.View;

namespace BrickInvaders
{

    namespace Model
    {

        public abstract class Observable
        {

            protected List<Observer> _observers;

            public Observable()
            {
                this._observers = new List<Observer>();
            }

            public void AddObserver(Observer v)
            {
                this._observers.Add(v);
            }

            public void RemoveObserver(Observer v)
            {
                this._observers.Remove(v);
            }

            abstract public void NotifyObservers();

        }
    }
}
