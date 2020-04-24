using System;
using System.Collections.Generic;
using System.Text;

namespace TowerDefense
{
    class SniperTower : Tower
    {
        protected override double Accuracy { get; } = 0.95;
        public SniperTower(MapLocation location) : base(location)
        { }
    }
}
