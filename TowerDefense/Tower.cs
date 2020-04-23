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
            for(int index = 0; index < invaders.Length; index++)
            {
                Invader invader = invaders[index];
            }
        }
    }
}
