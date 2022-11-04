class OperatorsDemo
{
    public static void Main (string[] args)
    {
        Console.WriteLine("-----------------Operator's Demo (total 9 operators shown here)-------------------------");

        Console.WriteLine("++++++++++++");
        int x = 5;
        int y = 3;
        Console.WriteLine(x+y);
        Console.WriteLine("--------------");
        Console.WriteLine(x-y);
        Console.WriteLine("******************");
        Console.WriteLine(x*y);
        Console.WriteLine("////////quotient//////////");
        x = 10;
        y = 2;
        Console.WriteLine(x/y);
        Console.WriteLine("modulus operator (remainder)");
        Console.WriteLine(x%y);
        Console.WriteLine("increment++");
        int z = 5;
        z++;
        Console.WriteLine(z);
        Console.WriteLine("decrement--");
        z--;
        Console.WriteLine(z);
        Console.WriteLine("Assignment operator int i=5; ");
        Console.WriteLine("addition assignment operator");
        int num = 21;
        num += 9;
        Console.WriteLine(num);
        Console.WriteLine();

        Console.ReadLine();
    }
}