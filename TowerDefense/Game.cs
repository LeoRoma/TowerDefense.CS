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
            
            int area = map.Width * map.Height;
            Console.WriteLine(area);
        }
    }
}
