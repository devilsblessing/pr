using System;

class QuadraticEquationSolver
{
    private double a, b, c;
    private double[] roots;

    public QuadraticEquationSolver(double a, double b, double c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
        CalculateRoots();
    }

    private double CalculateDiscriminant()
    {
        return b * b - 4 * a * c;
    }

    private void CalculateRoots()
    {
        double discriminant = CalculateDiscriminant();
        roots = new double[2];

        if (discriminant > 0)
        {
            roots[0] = (-b + Math.Sqrt(discriminant)) / (2 * a);
            roots[1] = (-b - Math.Sqrt(discriminant)) / (2 * a);
        }
        else if (discriminant == 0)
        {
            roots[0] = roots[1] = -b / (2 * a);
        }
        else
        {
            roots[0] = roots[1] = double.NaN; 
        }
    }

    public double[] GetRoots()
    {
        return roots;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите коэффициенты a, b и c для квадратного уравнения (ax^2 + bx + c = 0):");

        double a = Convert.ToDouble(Console.ReadLine());
        double b = Convert.ToDouble(Console.ReadLine());
        double c = Convert.ToDouble(Console.ReadLine());

        QuadraticEquationSolver solver = new QuadraticEquationSolver(a, b, c);

        double[] roots = solver.GetRoots();

        if (!double.IsNaN(roots[0]) && !double.IsNaN(roots[1]))
        {
            Console.WriteLine($"Корень 1: {roots[0]}");
            Console.WriteLine($"Корень 2: {roots[1]}");
        }
        else if (double.IsNaN(roots[0]))
        {
            Console.WriteLine("Уравнение не имеет действительных корней.");
        }
    }
}