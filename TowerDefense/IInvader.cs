using System;
using System.Collections.Generic;
using System.Text;

namespace TowerDefense
{
    interface IInvader
    {
        MapLocation Location { get; }

        int Health { get; }

        bool HasScored { get; }

        bool IsNeutralized { get; }

        bool IsActive { get; }

        void Move();

        void DecreaseHealth(int factor);
    }
}
