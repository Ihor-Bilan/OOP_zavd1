namespace Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the side length a");
            Console.Write("Side a = ");
            double side_a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the side length b");
            Console.Write("Side b = ");
            double side_b = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the side length c");
            Console.Write("Side c = ");
            double side_c = double.Parse(Console.ReadLine());
            TTriangle t1 = new TTriangle(side_a, side_b, side_c);
            Console.WriteLine(t1.IsExist(side_a, side_b, side_c));
            Console.WriteLine($"Perimeter is equal to {t1.Perimeter(t1.A, t1.B, t1.C)}");
            Console.WriteLine($"Area is equal to {t1.Area(t1.A, t1.B, t1.C)}");
        }
    }
}