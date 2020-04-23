using System;
using System.Collections.Generic;
using System.Text;

namespace TowerDefense
{
    class SniperTower : Tower
    {
        private static Random _random = new Random();
        protected override double Accuracy { get; } = 0.95;
        public SniperTower(MapLocation location) : base(location)
        { }
    }
}
