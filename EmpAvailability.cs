public class EmpAvailability
{
    public static void Main (string[] args)
    {
    l1:
        int IS_FULL_TIME = 1;
        int empCheck = RandomNumberGenerator.GetInt32(2);
        Console.WriteLine(empCheck);
        if(empCheck==IS_FULL_TIME)
        {
            Console.WriteLine("Employee is Present");
        }
        else
        {
            Console.WriteLine("Employee is Absent");
        }
        Console.ReadLine();
        goto l1;
    }
}