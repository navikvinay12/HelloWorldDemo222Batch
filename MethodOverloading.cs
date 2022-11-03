using System;

public class MethodOverloading
{
    public void addNumbers(int a, int b)
    {
        int c = a + b;
        Console.WriteLine("{0} + {1} = {2}", a, b, c);
    }
    public void addNumbers(float a, float b)
    {
        float c = a + b;
        Console.WriteLine("{0} + {1} = {2}", a, b, c);
    }
    public void addNumbers(int a, float b)
    {
        float c = a + b;
        Console.WriteLine("{0} + {1} = {2}", a, b, c);
    }
    public static void Main(string[] args)
    {
        MethodOverloading obj1 = new MethodOverloading();
        obj1.addNumbers(11, 22);
        obj1.addNumbers(2.3f, 3.4f);
        obj1.addNumbers(99, 0.99f);
        Console.ReadLine();
    }
}