using System;

public class Animal
{
    pubic void animalSound()
    {
        System.Console.WriteLine("The animal makes a sound");
    }
}
public class Pig : Animal
{
    pubic void animalSound()
    {
        System.Console.WriteLine("The pig says : wee wee");
    }
}
class Dog:Animal
{
    pubic void animalSound()
    {
        System.Console.WriteLine("The dog says: bow wow");
    }
}
class main
{
    public static void Main(String[] args)
    {
        Animal myAnimal = new Animal();
        Pig myPig = new Pig();
        Dog myDog = new myDog();

        myAnimal.animalSound();
        myPig.animalSound();
        myDog.animalSound();
        Console.ReadLine();
    }
}