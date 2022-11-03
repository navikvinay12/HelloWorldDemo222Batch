public class stringArrayWeekDay
{
    public static string weekDay(int dayNumber)
    {
        if ((dayNumber < 1) || (dayNumber > 7))
        {
            throw new InvalidOperationException("Day must be in the range 1 to 7 only");
        }
        string[] weekDay = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        return weekDay[dayNumber - 1];
    }
    public static void Main(String[] args)
    {
        Console.WriteLine("Enter any number in the range 1-7 to get its corresponding weekday");
        int dayNumber = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(stringArrayWeekDay.weekDay(dayNumber));
        Console.ReadLine();
    }
}