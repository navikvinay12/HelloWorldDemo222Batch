namespace Arithmetic
{
    class Addition
    {
        static void addition(int n1, int n2)
        {
            int Result = n1 + n2;
            Console.WriteLine("So the Result after addition is : " + Result);
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Addition of 2 Numbers Program");
            Console.WriteLine("Enter first integer number");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second integer number");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Addition.addition(n1, n2);
        }
    }
}