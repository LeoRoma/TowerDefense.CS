using System;
using System.Collections.Generic;
using System.Text;

namespace TowerDefense
{
    class Path
    {
        private readonly MapLocation[] _path;
        public Path(MapLocation[] path)
        {
            _path = path;
        }
    }
}
