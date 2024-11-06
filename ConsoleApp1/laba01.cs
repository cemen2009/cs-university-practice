using System;

namespace Laba01
{
    public abstract class Body 
    {
        public abstract double GetCapacity();
    }

    public class Sphere : Body
    {
        private float radius;

        public Sphere()
        {
            // default radius is 1
            radius = 1f;
        }

        public Sphere(float radius)
        {
            this.radius = radius;
        }

        public override double GetCapacity()
        {
            return 4 / 3 * Math.PI * Math.Pow(radius, 3);
        }
    }

    public class Parallelepiped : Body
    {
        private float baseWidth, baseLength;
        private float height;

        public Parallelepiped()
        {
            baseLength = 1f;
            baseWidth = 1f;
            height = 1f;
        }

        public Parallelepiped(float baseWidth, float baseLength, float height)
        {
            this.baseWidth = baseWidth;
            this.baseLength = baseLength;
            this.height = height;
        }

        public override double GetCapacity()
        {
            return height * baseLength * baseWidth;
        }
    }

    public class Tetrahedron : Body
    {
        private float edge;

        public Tetrahedron()
        {
            edge = 1f;
        }

        public Tetrahedron(float edge)
        {
            this.edge = edge;
        }

        public override double GetCapacity()
        {
            return Math.Pow(edge, 3) / (6 * Math.Sqrt(2));
        }
    }
}