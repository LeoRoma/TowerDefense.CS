using Xunit;
using TowerDefense;
using System;
using System.Collections.Generic;
using System.Text;

namespace TowerDefense.Tests
{
    public class MapLocationTests
    {
        [Fact()]
        public void ShouldThrowIfNotOnMap()
        {
            var map = new Map(3, 3);
            var exception = Assert.Throws<OutOfBoundsException>(()=> new MapLocation(3, 3, map));
        }

        //[Fact()]
        //public void InRangeOfTest()
        //{
        //    Assert.True(false, "This test needs an implementation");
        //}
    }
}