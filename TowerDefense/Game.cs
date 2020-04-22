using System;
using System.Collections.Generic;
using System.Text;

namespace TowerDefense
{
    class Game
    {
        static void Main(string[] args)
        {
            Map map = new Map(8, 5);

            Point point = new Point(4, 2);

            Console.WriteLine(point.DistanceTo(5, 5));
        }
    }
}
