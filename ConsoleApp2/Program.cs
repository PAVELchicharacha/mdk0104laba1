class program
{
    //метод вычисления наибольшего общего делителя
    public static int NOD(int a, int b)
    {
        while (a != b)
        {
            if (a > b)
                a -= b;
            else
                b -= a;
        }
        return a;
    }
    public static void Main()
    {
        //ввод числителя, знаминателя дроби, и их копий
        Console.WriteLine("Введите числитель дроби:");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите знаминатель дроби:");
        int b = int.Parse(Console.ReadLine());
        //вывод сокращенной дроби
        Console.WriteLine(" ");
        Console.WriteLine(a / NOD(a, b));
        Console.WriteLine(b / NOD(a, b));
    }
}