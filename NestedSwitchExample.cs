class WeekDay
{
    public static string displayWeekDay(int n1)
    {
        switch (n1)
        {
            case 1:
                return "Monday";
            case 2:
                return "Tueday";
            case 3:
                return "Wednesday";
            case 4:
                return "Thursday";
            case 5:
                return "Friday";
            case 6:
                return "Saturday";
            case 7:
                return "Sunday";
            default:
                throw new InvalidOperationException("Enter within range 1 to 7 only");
        }
    }
}
class BasicCalculator
{
    public static void simpleCalculator(int num1,int num2,char op)
    {
        switch (op)
        {
            case '+' :
                int result = 0;
                result = num1 + num2;
                Console.WriteLine("Result is : "+result);
            break;
            case '-' :
                result = num1 - num2;
                Console.WriteLine("Result is :"+ result);
            break;
            case '*' :
                result = num1 * num2;
            Console.WriteLine("Result is : " + result);
            break;
            case '/' :
                result = num1 / num2;
            Console.WriteLine("Result is :" + result);
            break;
        }
    }
}
class RandomGenerator
{
    public static void randomGenerator(int i)
    {
        Random random = new Random();

        switch (i)
        {
            case 1:
                int r1 = random.Next(0, 9);
                Console.WriteLine("The single digit random number generated is :" + r1);
                break;

            case 2:
                int r2 = random.Next(10, 100);
                Console.WriteLine("The two digit random number generated is :" + r2);
                break;
            case 3:
                int r3 = random.Next(101, 1000);
                Console.WriteLine("The three digit random number generated is :" + r3);
                break;
        }
    }
}

class NestedSwitchExample
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Welcome to Nested Switch Example ! Please select any one from below given options :-\n");
        l1:
        Console.WriteLine(" for Displaying WeekDays press --> 1\n for using simple Calculator press --> 2\n for generating Random Numbers --> 3\n");
        int outerCaseValue = Convert.ToInt32(Console.ReadLine());

        switch (outerCaseValue)
        {
            case 1:
                Console.WriteLine("Enter any number in the range 1-7 to get its corresponding weekday");
                int n1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(WeekDay.displayWeekDay(n1));
                break;
            case 2:
                Console.WriteLine("Welcome to Basic Calculator Program \n Please enter the first number");
                int num1=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the second number");
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("please input anyone operator (+,-,*,/) to calculate ");
                char op = Console.ReadLine()[0];
                BasicCalculator.simpleCalculator(num1,num2,op);
                break;
            case 3:
                Console.WriteLine("Welcome to Random Generator program. \n\n to generate one digit number  : press 1\n to generate two digit number  : press 2\n to generate three digit number : press 3");
                int i = Convert.ToInt32(Console.ReadLine());
                RandomGenerator.randomGenerator(i);
                break;
            default:
                Console.WriteLine("OOPS! Your input doesn't matched with any of the options provided.You can try again...  ");
                break;
                goto l1;
        }
        Console.WriteLine("Thanks for using Application ! Looking to see you again ... ");
        Console.ReadLine();
    }
}
