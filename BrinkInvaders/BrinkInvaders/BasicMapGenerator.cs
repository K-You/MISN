using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

using BrickInvaders.Model;

namespace BrickInvaders
{

    namespace Controller
    {

        public class BasicMapGenerator : MapGenerator
        {
            public const int MINWIDTH = 6;
            public const int MINHEIGHT = 10;
            public BasicMapGenerator()
            {
                this.rand = new Random();
            }

            private Random rand;

            public List<BasicBrick> generateMap(int level, int width, int height, Vector2D speed)
            {

                if (width <= MINWIDTH || height <= MINHEIGHT)
                {
                    throw new ArgumentOutOfRangeException();
                }

                List<BasicBrick> tempList = new List<BasicBrick>();
                
                double levelOffset = Math.Sqrt(2 * Math.Sqrt(level));//Calcule l'offset de probabilité en fonction du niveau, selon une évolution type racine un peu ralentie

                bool previous = true;
                int since = 0;
                for (int i = height - 1; i > 3; i--)
                {
                    if (previous && since < 3)//Il y a eu des briques avant donc j'attends 3 lignes minimum
                    {
                        since++;
                    }
                    else
                    {
                        previous = rand.Next(0, 10) <= (4 + (levelOffset-2));//=Est-ce que je mets des briques sur cette ligne ou j'attends la prochaine
                        if (previous)
                        {
                            since = 0;
                            int x = rand.Next(0, width);
                            tempList.Add(new BasicBrick(new Vector2D(x, i), speed));//J'ajoute une brique
                            if (x <= (width / 2) - 3 && rand.Next(0, 10) <= (3 + levelOffset))//Si elle est pas centrée et si le rand dit oui, je mets une brique de l'autre côté, horizontalement
                            {
                                x = rand.Next(0, (width / 2) - 2);
                                tempList.Add(new BasicBrick(new Vector2D(width - 1 - x, i), speed));
                            }
                            else if (x >= (width / 2) + 3 && rand.Next(0, 10) <= (3 + levelOffset))//Ou de l'autre côté
                            {
                                x = rand.Next((width / 2) + 2, width);
                                tempList.Add(new BasicBrick(new Vector2D(width - 1 - x, i), speed));
                            }
                        }
                    }
                }

                List<BasicBrick> list = new List<BasicBrick>();
                foreach (BasicBrick brick in tempList)
                {
                    list.Add(brick);
                    int x = (int)brick.Position.X;
                    int y = (int)brick.Position.Y;
                    int nY, nX;
                    for (nX = x - 1; nX <= x + 1; nX++)
                    {
                        for (nY = y - 1; nY <= y + 1; nY++)
                        {
                            if ((nX!=x || nY !=y) && nX >= 0 && nX <= width - 1 && nY >= 0 && nY <= height - 1 && rand.Next(0, 10) <= (6+levelOffset))//Si rand veut bien je rajoute les briques autour des briques du dessus pour dessiner des "vaisseaux"
                            {
                                list.Add(new BasicBrick(new Vector2D(nX, nY), speed));
                            }
                        }
                    }
                    nX = x - 2; nY = y;
                    if (nX >= 0 && nX <= width - 1 && nY >= 0 && nY <= height - 1 && rand.Next(0, 10) <= (6 + levelOffset))//idem
                    {
                        list.Add(new BasicBrick(new Vector2D(nX, nY), speed));
                    }
                    nX = x + 2;
                    if (nX >= 0 && nX <= width - 1 && nY >= 0 && nY <= height - 1 && rand.Next(0, 10) <= (6 + levelOffset))//idem
                    {
                        list.Add(new BasicBrick(new Vector2D(nX, nY), speed));
                    }

                }

                return list;
            }

            public Ship generateShip(int width, int height)
            {
                Ship s = new Ship("");
                s.Position = new Vector2D((width-s.Width) / 2, 0);
                return s;
            }
        }
    }
}
