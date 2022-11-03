using System;
using System.ComponentModel.Design.Serialization;
using System.Globalization;
using System.Linq.Expressions;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;


public class A
{
    public void showA()
    {
        Console.WriteLine("Class A");
    }
}
public class B : A
{
    public void showB()
    {
        Console.WriteLine("Class B");
    }
}
public class C : B
{
    public void showC()
    {
        Console.WriteLine("Class C");
    }
}
public class InheritanceDemo
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Class A scope is limited to Class A only");
        A a = new A();
        a.showA();      //Class A
        Console.WriteLine();

        Console.WriteLine("Class B will have all methods of Class A and Class B ");
        B b = new B();
        b.showA();      //Class A
        b.showB();      //Class B
        Console.WriteLine();

        Console.WriteLine("Class C will have all methods of Class A,Class B and Class C ");
        C c = new C();
        c.showA();      //Class A
        c.showB();      //Class B
        c.showC();      //Class C

        Console.ReadLine();
    }
}











