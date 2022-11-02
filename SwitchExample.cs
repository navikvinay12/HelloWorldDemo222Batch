using System;
using System.ComponentModel.Design.Serialization;
using System.Globalization;
using System.Linq.Expressions;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;

public class SwitchExample  //Addition Swapping & Playing with Object .
{
    string trainingInstitute = "Bridgelabz (RFP Batch)" ;
    string humanName;
    string phoneNo;
    public void humanDetails()
    {
        Console.WriteLine("Training Center - {0}\nStudent Name is - {1}\nPhone number is - {2}",trainingInstitute, humanName, phoneNo);
    }
    public static void Add2Numbers(int no1, int no2)
    {
        int result = no1 + no2;
        Console.WriteLine("After adding the result is : "+result);
    }
    public static void swapNumbers(int num1 , int num2)
    {
        Console.WriteLine("Before Swapping :- First Number is :{0} and Second Number is :{1}", num1, num2);
        int temp = num1;
        num1 = num2;
        num2 = temp;
        Console.WriteLine("After Swapping :- First Number became :{0} and Second Number became :{1}" , num1,num2);
    }
    public static void Main(String[] args)
    {
        startingPoint:
        Console.WriteLine("Welcome! Please choose any one program from below options");
        Console.WriteLine(" 1.Addition of 2 Programs\n 2.Swapping two numbers\n 3.Student Details\n 4.Know Current Date and Time");
        int choice = Convert.ToInt32(Console.ReadLine());
        switch (choice)
        {
            case 1:
                Console.WriteLine("Welcome to Addition program of 2 Numbers");
                Console.WriteLine("Enter the First Number ");
                int no1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Second Number ");
                int no2 = Convert.ToInt32(Console.ReadLine());
                SwitchExample.Add2Numbers(no1, no2);
                break;

            case 2:
                Console.WriteLine("Welcome to Swapping of 2 numbers program");
                Console.WriteLine("Enter the First Number ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Second Number ");
                int num2 = Convert.ToInt32(Console.ReadLine());
                SwitchExample.swapNumbers(num1, num2);
                break;
            case 3:
                SwitchExample human1=new SwitchExample();
                human1.humanName = "Krishna";
                human1.phoneNo = "9786786786";
                human1.humanDetails();
                Console.WriteLine();
                SwitchExample human2 = new SwitchExample();
                human2.humanName = "Shree";
                human2.phoneNo = "9968768767";
                human2.humanDetails();
                Console.WriteLine();
                break;
            case 4:
                DateTime now = DateTime.Now;
                Console.WriteLine(now.ToString("F"));
                break;

            default:
                Console.WriteLine("Invalid ! ");
                Console.WriteLine("Press enter to try once again");
                Console.ReadLine();
                goto startingPoint;
                break;
        }
        Console.WriteLine("Press enter to use it again");
        Console.ReadLine();
        goto startingPoint;
    }
}











