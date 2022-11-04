class DataTypes
{
    public static void Main (string[] args)
    {
        Console.WriteLine("-----------------Data Types-------------------------");
        int i;
        i = 10; //takes 4 byte of meory to store
        i = 20;     //i overridden
        Console.WriteLine("the value of i =" + i);
        int j = 3;

        Console.WriteLine(i+j);

        double num = 45.45; //takes 8 byte of memory to store .
        Console.WriteLine(num);

        string firstName = "John";
        string lastName = "Doe";
        string fullName = firstName +"  " +lastName;
        Console.WriteLine(fullName);

        bool b =true;
        Console.WriteLine(b);       //1 byte

        char op= '+';       //writing operator in place of op will give error ,why ?bcoz operator is a keyword (pre-defined words cant be used ) .
        Console.WriteLine(op);

        int myNum = 1234567890;     //upto 10 digits it have taken .inserting 11th digit will give error .
        long no = 8234567890123456789L;     //replacing ist digit by i.e 8 by 9 will give error .
        float f = 3.345F;                 //here small f and caps F both are working .
        double d = 19.90D;
        Console.WriteLine(myNum);
        Console.WriteLine(no);
        Console.WriteLine(d);

        Console.ReadLine();
    }
}