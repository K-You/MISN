using BrickInvaders.Controller;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace BrickInvaders
{
    namespace Model
    {
        class XMLScoreParser
        {
            public const string FILENAME = "data.xml";
            private XDocument xdoc;
            private List<Score> Scores;
            public XMLScoreParser()
            {
                
                try
                {
                    this.xdoc = XDocument.Load(FILENAME);
                    Scores = this.ParseScores();
                }
                catch (FileNotFoundException e)
                {
                    this.xdoc = new XDocument(new XElement("Scores"));
                    Scores = new List<Score>();
                    this.xdoc.Save(FILENAME);
                }
                
            }

            private List<Score> ParseScores()
            {
                XElement root = this.xdoc.Root;                
                IEnumerable<XElement> list = root.Descendants(XName.Get("Score"));
                List<Score> scores = new List<Score>();
                foreach (XElement item in list)
                {
                    string Name = item.Element("Name").Value;

                    scores.Add(new Score(new Player(Name), int.Parse(item.Element("Value").Value), (GameMode)Activator.CreateInstance(Type.GetType(item.Element("Mode").Value))));
                }
                return scores;
            }

            public List<Score> GetScores(){
                return Scores;
            }

            public void StoreScores(List<Score> Scores)
            {
                this.Scores = Scores;
                this.Scores.Sort((x, y) => y.CompareTo(x));
                XElement[] Xscores = new XElement[Scores.Count];
                int i =0;
                foreach (Score sc in Scores)
                {
                    Xscores[i++] = new XElement("Score", new XElement("Name", sc.Player.Pseudo), new XElement("Value", sc.Value), new XElement("Mode", sc.Mode.GetType().FullName));
                }
                this.xdoc = new XDocument(new XElement("Scores", Xscores));
                
                this.xdoc.Save(FILENAME);
            }
        }
    }
}
