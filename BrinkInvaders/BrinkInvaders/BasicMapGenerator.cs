using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace BrinkInvaders
{
    public class BasicMapGenerator:MapGenerator
    {

        public List<BasicBrick> generateMap(int level,int width, int height)
        {
            if (width <= 6 && height <= 10)
            {
                throw new ArgumentOutOfRangeException();
            }
            List<BasicBrick> tempList = new List<BasicBrick>();
            Random rand = new Random();
            bool previous = true;
            int since = 0;
            for(int i=height-1;i>0;i--)
            {
                if (previous && since < 3)
                {
                    since++;
                }
                else
                {
                    previous = rand.Next(0, 10) <= 4;
                    if (previous)
                    {
                        since = 0;
                        int x = rand.Next(0, width);
                        tempList.Add(new BasicBrick(new Point(x,i)));
                        if (x <= (width / 2) - 3 && rand.Next(0, 10) <= 3)
                        {
                            x = rand.Next(0, (width/2)-2);
                            tempList.Add(new BasicBrick(new Point(width-1-x, i)));
                        }
                        else if (x >= (width / 2) + 3 && rand.Next(0, 10) <= 3)
                        {
                            x = rand.Next((width / 2)+2, width);
                            tempList.Add(new BasicBrick(new Point(width-1 - x, i)));
                        }
                    }
                }
            }
            List<BasicBrick> list = new List<BasicBrick>();
            foreach (BasicBrick brick in tempList)
            {
                list.Add(brick);
                int x = brick.Position.X;
                int y = brick.Position.Y;
                int nY, nX;
                for(nX=x-1;nX<=x+1;nX++)
                {
                    for (nY = y-1; nY <= y+1; nY++)
                    {
                        if(nX>=0&&nX<=width-1&&nY>=0&&nY<=height-1&&rand.Next(0,10)<=7)
                        {
                            list.Add(new BasicBrick(new Point(nX, nY)));
                        }
                    }
                }
                nX = x - 2; nY = y;
                if (nX >= 0 && nX <= width - 1 && nY >= 0 && nY <= height - 1 && rand.Next(0, 10) <= 7)
                {
                    list.Add(new BasicBrick(new Point(nX, nY)));
                }
                nX = x + 2;
                if (nX >= 0 && nX <= width - 1 && nY >= 0 && nY <= height - 1 && rand.Next(0, 10) <= 7)
                {
                    list.Add(new BasicBrick(new Point(nX, nY)));
                }
			
            }
            return list;
        }

        public Ship generateShip()
        {
            return new Ship("Basic ship!");
        }

        public void test()
        {
            int width=40, height=60;
            List<BasicBrick> list = this.generateMap(1, width, height);
            char[,] lines = new char[height, width];
            foreach (BasicBrick item in list)
            {
                lines[item.Position.Y,item.Position.X] = 'X';
            }
            string delimiter = "";
            for (int i = 0; i <= width; i++)
            {
                delimiter += "-";
            }
            Console.WriteLine(delimiter);
            for (int i = 0; i < height; i++)
            {
                string s="|";
                for (int j = 0; j < width; j++)
                {
                    s += lines[i, j];
                }
                Console.WriteLine(s+'|');
            }
            Console.WriteLine(delimiter);
        }
    }
}
