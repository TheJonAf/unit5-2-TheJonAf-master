using System;

namespace Test
{
    [AttributeUsage(AttributeTargets.All)]
    public class PointsAttribute : Attribute
    {
        public PointsAttribute(int points)
        {
            Points = points;
        }

        public int Points { get; }
    }
}
