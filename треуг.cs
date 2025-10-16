class Program
{
    static void Main()
    {
        Console.WriteLine("Введите длины трёх сторон треугольника:");

        Console.Write("Сторона a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Сторона b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Сторона c: ");
        double c = Convert.ToDouble(Console.ReadLine());


        if (a <= 0 || b <= 0 || c <= 0)
        {
            Console.WriteLine("Ошибка. Стороны должны быть положительными");
            return;
        }

        if (a + b > c && a + c > b && b + c > a)
        {
            Console.WriteLine("Треугольник существует");

            if (a == b && b == c)
            {
                Console.WriteLine("Это равносторонний треугольник");
            }
            else if (a == b || a == c || b == c)
            {
                Console.WriteLine("Это равнобедренный треугольник");
            }
            else
            {
                Console.WriteLine("Это разносторонний треугольник");
            }
        }
        else
        {
            Console.WriteLine("Треугольника не существует");
            Console.WriteLine("Сумма любых двух сторон должна быть больше третьей стороны");
        }
    }
}