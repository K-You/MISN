using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BrinkInvaders
{
    public abstract class GameMode
    {
        public MapGenerator Generator { get; set; }
        
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

        public GameMode(MapGenerator Generator,String label)
        {
            this.Generator = Generator;
            this.Label = label;
        }
    }
}
