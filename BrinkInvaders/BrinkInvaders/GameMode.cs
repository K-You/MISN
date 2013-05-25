using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BrinkInvaders
{
    public class GameMode
    {
        private string _label;

        public string Label
        {
            get { return _label; }
            set { _label = value; }
        }


        private List<Score> _scores;

        public List<Score> getBestScores
        {
            get { return _scores; }
        }
    }
}
