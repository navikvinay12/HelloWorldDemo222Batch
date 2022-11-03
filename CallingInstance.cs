<<<<<<< HEAD
﻿public class Human
{
    public string personName;
    public string phoneNum;
    public void talk()
    {
        Console.WriteLine("Human can Interact with each other");
    }
    public void humanInfo()
    {
        Console.WriteLine("Person Name : {0}  and Person Phone No : {1}", personName, phoneNum);
        //Console.WriteLine("Person Name - "+ personName +" Person Phone no - "+ phoneNum);
    }
}
public class Origin
{
    public static void Main(string[] args)
    {
        Human human1 = new Human();
        human1.personName = "RAM";
        human1.phoneNum = "9786786786";
        human1.humanInfo();

        Human human2 = new Human();
        human2.personName = "AKSHAY";
        human2.phoneNum = "7867867869";
        human2.humanInfo();
        Console.ReadLine();
    }
}
=======
﻿public class Human
{
    public string personName;
    public string phoneNum;
    public void talk()
    {
        Console.WriteLine("Human can Interact with each other");
    }
    public void humanInfo()
    {
        Console.WriteLine("Person Name : {0}  and Person Phone No : {1}", personName, phoneNum);
        //Console.WriteLine("Person Name - "+ personName +" Person Phone no - "+ phoneNum);
    }
}
public class Origin
{
    public static void Main(string[] args)
    {
        Human human1 = new Human();
        human1.personName = "RAM";
        human1.phoneNum = "9786786786";
        human1.humanInfo();

        Human human2 = new Human();
        human2.personName = "AKSHAY";
        human2.phoneNum = "7867867869";
        human2.humanInfo();
        Console.ReadLine();
    }
}
>>>>>>> e935b03c1ea24105edf5afbd66d99eff90b6fce5
