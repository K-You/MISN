using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BrinkInvaders
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player("Red", 1);
            Console.WriteLine(player.Pseudo);
            Console.Read();
        }
    }
}
