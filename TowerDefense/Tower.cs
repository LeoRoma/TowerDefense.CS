using System;
using System.Collections.Generic;
using System.Text;

namespace TowerDefense
{
    class Tower
    {
        private readonly MapLocation _location;

        public Tower(MapLocation location)
        {
            _location = location;
        }

        public void FireOnInvaders(Invader[] invaders)
        {
           foreach(Invader invader in invaders)
            {
                if(invader.IsActive && _location.InRangeOf(invader.Location, 1))
                {
                    invader.DecreaseHealth(1);
                    break;
                }
            }
        }
    }
}
