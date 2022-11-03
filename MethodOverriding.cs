using System;

public class Parent
{
    public virtual void show()
    {
        Console.WriteLine("Parent Class");
    }
}
public class Child : Parent
{
    public override void show()
    {
        Console.WriteLine("Child Class");
    }

}

class MethodOverriding
{
    public static void Main(string[] args)
    {
        Parent pObj = new Parent();
        pObj.show();         //Parent

        pObj = new Parent();
        pObj.show();         //Parent

        pObj = new Child();
        pObj.show();         //Child  (But output changes to Parent if I'll remove virtual and overriding keyword)

        Child cObj = new Child();
        cObj.show();        //Child

        cObj = new Child();
        cObj.show();        //Child

        Console.ReadLine();
    }
}
