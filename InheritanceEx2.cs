
class BaseClass
{
    public string name;
    public string subject;
    public void readers(string name,string subject)
    {
        this.name = name;
        this.subject = subject;
        Console.WriteLine("My name is :"+name);
        Console.WriteLine("My Favourite subject is :"+subject);
    }
}
class SubClass:BaseClass
{
    static int i = 1;
    public SubClass()
    {
        Console.WriteLine(i);
        i++;
    }
}
class Sudo
{
    static void Main(String[] args)
    {
        SubClass obj=new SubClass();
        obj.readers("Krishna","Math");
        obj=new SubClass();
        obj.readers("John", "C#");
        Console.ReadLine();
    }
}