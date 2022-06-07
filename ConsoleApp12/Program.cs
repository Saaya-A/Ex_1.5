class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите x ");
        int x = int.Parse(Console.ReadLine());
        int a = 1000;
        int kol = 0;
        while (a != 0)
        {
            Console.WriteLine("Введите число: ");
            int y = int.Parse(Console.ReadLine());
            a = y;
            if (y > x)
            {
                kol += y;
            }
        }
        Console.WriteLine("Сумма чисел, больших х = " + kol);
    }
}