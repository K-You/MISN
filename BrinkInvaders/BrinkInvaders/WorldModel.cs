using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BrinkInvaders
{
    public abstract class WorldModel
    {

        protected List<WorldView> _observers;

        public WorldModel() {
            this._observers = new List<WorldView>();
        }

        public void addObserver(WorldView v) {
            this._observers.Add(v);
        }

        public void removeObserver(WorldView v) {
            this._observers.Remove(v);
        }

        abstract public void notifyObservers();

    }
}
