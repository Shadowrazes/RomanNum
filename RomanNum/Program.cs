public class Program
{
    public static void Main()
    {
        RomanNumber a = new RomanNumber(432);
        RomanNumber b = new RomanNumber(2368);
        RomanNumber c = new RomanNumber(1000);
        RomanNumber d = new RomanNumber(2);

        Console.WriteLine("A = 432 = " + a.ToString());
        Console.WriteLine("B = 2368 = " + b.ToString());
        Console.WriteLine("C = 1000 = " + c.ToString());
        Console.WriteLine("D = 2 = " + d.ToString());
        Console.WriteLine("");

        Console.WriteLine("B + C = " + (b + c).ToString());
        Console.WriteLine("B - C = " + (b - c).ToString());
        //Console.WriteLine((c - b).ToString()); //исключение
        Console.WriteLine("D * C = " + (d * c).ToString());
        Console.WriteLine("C / D = " + (c / d).ToString());
        //Console.WriteLine((d / c).ToString()); //исключение
        Console.WriteLine("");

        Console.WriteLine("Сортировка");
        RomanNumber[] numbers = { a, b, c, d };
        Array.Sort(numbers);
        foreach(RomanNumber number in numbers)
        {
            Console.WriteLine(number.ToString());
        }
        Console.WriteLine("");

        Console.WriteLine("Копирование");
        var f = (RomanNumber)c.Clone();
        Console.WriteLine(f.ToString());
    }
}

