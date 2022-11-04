class StringsPractice
{
    public static void Main (string[] args)
    {
        Console.WriteLine("########## String Awareness #########");
        string greeting = "Hello";      //creating a string 
        Console.WriteLine(greeting);

        string txt = "abcdEFGHIJKLMNOPQRSTUVWXYZ";
        Console.WriteLine(txt.Length);      //26

        Console.WriteLine(txt.ToLower());       //abcdefghijklmnopqrstuvwxyz
        Console.WriteLine(txt.ToUpper());       //ABCDEFGHIJKLMNOPQRSTUVWXYZ

        String firstName = "Bridge";
        String lastName = "Labz";
        Console.WriteLine("Concatenation of string :"+firstName+lastName);    //concatenation of string
        String fullName = String.Concat(firstName, lastName);   //concatenation using String.Concat() of String class .

        String name = $"My full name is :{firstName}{lastName}";    //interpolation
        Console.WriteLine(name);

        String myString = "Position";
        Console.WriteLine(myString[0]);     //P     (we can get any character by referring its index posiiton 0 to n-1 )

        Console.WriteLine(myString.IndexOf("o"));   //1  (passing char will return its index position)

        int insert=myString.IndexOf('t');
        Console.WriteLine("Index value of t from \"Position\" is : "+insert);
        String ssOutput=myString.Substring(insert);
        Console.WriteLine("After SubString of \"Position\"  : " +ssOutput);
        Console.WriteLine("String are always written in \"Double Quotes\"  ");//printing "",so use \backslash just before "double quote .
        Console.ReadLine();
    }
}