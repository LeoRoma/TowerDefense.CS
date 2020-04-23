using System;
using System.Collections.Generic;
using System.Text;

namespace TowerDefense
{
    class Tower
    {
        protected virtual int Range { get; } = 1;
        protected virtual int Power { get; } = 1;
        protected virtual double Accuracy { get; } = .75;

        protected static readonly Random _random = new Random();

        protected readonly MapLocation _location;

        public Tower(MapLocation location)
        {
            _location = location;
        }

        protected virtual bool IsSuccessfulShot()
        {
            return _random.NextDouble() < Accuracy;
        }
        public virtual void FireOnInvaders(Invader[] invaders)
        {
           foreach(Invader invader in invaders)
            {
                if(invader.IsActive && _location.InRangeOf(invader.Location, Range))
                {
                    if(IsSuccessfulShot())
                    {
                        invader.DecreaseHealth(Power);
                        
                        if(invader.IsNeutralized)
                        {
                            Console.WriteLine("Neutralized an invader!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Miss");
                    }
                    break;
                }
            }
        }
    }
}
