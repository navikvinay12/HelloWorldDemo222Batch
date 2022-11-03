public class EmpWage
{
    public static void Main (string[] args)
    {
    l1:
        //Constants
        int IS_FULL_TIME = 1;
        int EMP_RATE_PER_HOUR = 20;
        //variables
        int empHrs = 0;
        int empWage = 0;
        Random random = new Random();
        //computations
        int empCheck = random.Next(0, 2);
        Console.WriteLine(empCheck);
        if(empCheck==IS_FULL_TIME)
        {
            Console.WriteLine("Employee is Present");
            empHrs = 8;
        }
        else
        {
            Console.WriteLine("Employee is Absent");
            empHrs = 0;
        }
        empWage = EMP_RATE_PER_HOUR * empHrs;
        Console.WriteLine("Emp Wage : "+empWage);
        Console.ReadLine();
        goto l1;
    }
}