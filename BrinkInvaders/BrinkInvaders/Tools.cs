﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using BrickInvaders.Model;

namespace BrickInvaders
{

    namespace Tools
    {

        class Utils
        {

            public static bool intersects(Rectangle r1, Rectangle r2)
            {
                double minX1 = r1.Origin.X;
                double minY1 = r1.Origin.Y;
                double maxX1 = minX1 + r1.Width;
                double maxY1 = minY1 + r1.Height;

                double minX2 = r2.Origin.X;
                double minY2 = r2.Origin.Y;
                double maxX2 = minX2 + r2.Width;
                double maxY2 = minY2 + r2.Height;

                double maxgauche = Math.Max(minX1,minX2);
                double mindroit = Math.Min(maxX1, maxX2);
                double maxbas = Math.Max(minY1, minY2);
                double minhaut = Math.Min(maxY1, maxY2);

                return maxgauche < mindroit && maxbas < minhaut;
            }

            public static bool contains(Rectangle e, double x, double y)
            {
                double minX = e.Origin.X;
                double minY = e.Origin.Y;
                double maxX = minX + e.Width;
                double maxY = minY + e.Height;

                return ((x >= minX && x <= maxX) && (y >= minY && y <= maxY));
            }

            public static bool contains(Rectangle e, Vector2D position)
            {
                return Utils.contains(e, position.X, position.Y);
            }

        }

    }
}