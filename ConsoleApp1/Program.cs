using System;
using BasicOOP;

namespace BasicOOP
{
    public class Body
    {
        public Body()
        {

        }

        public virtual float GetCalculatedArea()
        {
            Console.WriteLine("Area calculations are not provided");
            return 0;
        }
    }

    public class Sphere : Body
    {
        private float radius;

        public Sphere(float radius)
        {
            this.radius = radius;
        }

        public override float GetCalculatedArea()
        {
            return 4 * (float)Math.PI * radius * radius;
        }
    }
}


public static class Program
{
    public static void Main(string[] args)
    {
        Sphere sphere = new Sphere(2);
        Console.WriteLine($"area: {sphere.GetCalculatedArea()}");
    }
}