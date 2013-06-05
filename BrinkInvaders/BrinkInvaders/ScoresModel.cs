using BrickInvaders.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BrickInvaders
{
    namespace Model
    {
        public class ScoresModel
        {
            private XMLScoreParser _parser;
            private List<Score> _scores;
            private GameMode gameMode;

            public ScoresModel()
            {
                this._parser = new XMLScoreParser();
                this._scores = this._parser.GetScores();
            }

            public ScoresModel(GameMode gameMode)
            {
                this.gameMode = gameMode;
            }
            public List<Score> Scores
            {
                get { return _scores; }
                set { _scores = value; }
            }

            public void AddScore(Player player, int value, GameMode mode)
            {
                List<Score> thisList = new List<Score>();
                Boolean added = false;
                foreach (Score score in this._scores)
                {
                    if (score.Mode.GetType().FullName.Equals(mode.GetType().FullName))
                    {
                        thisList.Add(score);
                    }
                }
                int min = int.MaxValue;
                foreach (Score score in thisList)
                {
                    if (score.Value < min)
                    {
                        min = score.Value;
                    }
                }
                if (value > min || thisList.Count < 5)
                {
                    this._scores.Add(new Score(player, value, mode));
                    added = true;
                }
                if (added && thisList.Count >= 5)
                {
                    Score last = thisList[0];
                    foreach (Score score in thisList)
                    {
                        if (score.Value == min)
                        {
                            last = score;
                        }
                    }
                    this._scores.Remove(last);
                }
                _parser.StoreScores(this._scores);
            }
            public List<Score> GetScores()
            {
                return this.GetScores(this.gameMode);
            }
            public List<Score> GetScores(GameMode mode)
            {
                List<Score> returnedList = new List<Score>();
                foreach (Score score in this._scores)
                {
                    if (score.Mode.GetType().FullName.Equals(mode.GetType().FullName))
                    {
                        returnedList.Add(score);
                    }
                }
                returnedList.Sort((x, y) => y.CompareTo(x));
                return returnedList;
            }
        }
    }
}
