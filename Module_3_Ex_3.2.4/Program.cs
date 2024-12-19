using System;

class MainClass
{
    public static void Main(string[] args)
    {

        const string MyName = "Jane";
        
        Console.WriteLine(MyName);

        Console.WriteLine("Hello,\n world");
        Console.WriteLine("\t I am 45 years old");
        Console.WriteLine("\t My name is Alexander");
        Console.WriteLine("\u0040");
        Console.WriteLine("\x23");
        Console.WriteLine(true);
        Console.WriteLine(false);
        Console.WriteLine(5);

        //string MyName = "Jane";
        byte MyAge = 27;
        bool HaveIApet = true;
        double MyShoeSize = 37.5;

        Console.WriteLine("My name is " + MyName);
        Console.WriteLine("MyAge " + MyAge);
        Console.WriteLine("Do I have a pet? " + HaveIApet);
        Console.WriteLine("My shoe size is " + MyShoeSize);


        Console.ReadKey();
    }
}