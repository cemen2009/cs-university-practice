using Laba01;
using MathOperations;

public static class Program
{
    public static void Main(string[] args)
    {
        // Sphere sphere = new Sphere(2f);
        // Parallelepiped parallelepiped = new Parallelepiped(1f, 3.5f, 1.2f);
        // Tetrahedron tetrahedron = new Tetrahedron(3f);

        // Console.WriteLine($"sphere volume: {sphere.GetCapacity()}\nparallelepiped volume: {parallelepiped.GetCapacity()}\ntetrahedron volume: {tetrahedron.GetCapacity()}");

        var _operator = new MathOperations.MathOperations();

        Console.WriteLine($"factorial 5: {_operator.Factorial(5)}\ntriangle: a = 5, b = 3.5, c = 6\nS = {_operator.CalculateTriangleArea(5, 3.5f, 6)}");
    }
}