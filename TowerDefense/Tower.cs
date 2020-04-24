using System;

namespace TowerDefense
{
    class Tower
    {
        protected virtual int Range { get; } = 1;
        protected virtual int Power { get; } = 1;
        protected virtual double Accuracy { get; } = .75;

        protected readonly MapLocation _location;

        public Tower(MapLocation location)
        {
            _location = location;
        }

        public virtual bool IsSuccessfulShot()
        {
            //TowerCheker();
            return Random.NextDouble() < Accuracy;
        }
        public virtual void FireOnInvaders(IInvader[] invaders)
        {
            foreach (IInvader invader in invaders)
            {
                if (invader.IsActive && _location.InRangeOf(invader.Location, Range))
                {
                    if (IsSuccessfulShot())
                    {
                        invader.DecreaseHealth(Power);


                        if (invader.IsNeutralized)
                        {
                            Console.WriteLine("Neutralized an invader at " + invader.Location + "!");
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

        //private void TowerCheker()
        //{
        //    if (_location.X == 3 && _location.Y == 3)
        //    {
        //        Console.WriteLine("Sniper Tower hitted a target");
        //    }
        //    else if (_location.X == 1 && _location.Y == 3)
        //    {
        //        Console.WriteLine("Normal Tower hitted a target");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Powerful Tower hitted a target");
        //    }
        //}
    }
}
