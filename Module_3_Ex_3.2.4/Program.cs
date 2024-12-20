﻿using System;
using System.Data;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

class MainClass
{
    public static void Main(string[] args)
    {
        /*
        const string MyName = "Jane";

        Console.WriteLine($"My name is {MyName}");

        Console.WriteLine("\tHello,\n world");
        Console.WriteLine("\t I am 45 years old");
        Console.WriteLine();
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

        DaysOfWeek MyFavoriteDay;

        MyFavoriteDay = DaysOfWeek.Friday;

        Console.WriteLine(MyFavoriteDay);

        Semaphore SemaphoreColor;

        SemaphoreColor = Semaphore.Green;

        Console.WriteLine(SemaphoreColor);


        string MyName1 = "Alexander";
        Console.WriteLine("Hello, world");
        Console.WriteLine();
        Console.WriteLine("My name {0}", MyName1);

        //0 — позиция нашей переменной. То есть переменная будет на позиции 0.


        //Также мы можем вставить в строку не переменную, а строковый литерал:
        Console.WriteLine("My name {0}", "Alexander New");


        //И, естественно, мы можем использовать несколько переменных при выводе. В этом случае располагаем их в порядке нумерации «мест».
        var age = 27;
        var weight = 50;
        Console.WriteLine("Age {0} \n weight {1}", age, weight);


        string MyName2 = "Computer";
        Console.WriteLine("Hello, human");
        Console.WriteLine("My name is {0}", MyName2);
        Console.Write("What is your name? ");
        string YourName = Console.ReadLine();
        Console.Write("Happy to meet you, {0} ", YourName);
        

        double result = 5.0 / 2.0 ;
        Console.WriteLine("5 / 2 = {0}", result);

        double result1 = 5.0 % 2.0;
        Console.WriteLine("5 % 2 = {0}", result1);

        int counter = 10;
        Console.WriteLine("Value: {0} Increment: {1}", counter, ++counter);

        int counter1 = 10;
        Console.WriteLine("Value: {0} Increment: {1}", counter1, counter1++);

        double result3 = 10 % 3;

        Console.WriteLine("Result of 10 % 3 is: {0}", result3);

        int olddata = 6;
        string data = olddata.ToString();

        Console.WriteLine(data);

        Console.WriteLine(olddata);
        
        Console.Write("Enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Your age is {0} ", age);
        Console.ReadKey();

        Console.Write("Enter your age: ");
        int age1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Your age is {0} ", age1);
        Console.ReadKey();

        Console.Write("Enter your age: ");
        int age2;
        bool iscorrect = int.TryParse(Console.ReadLine(), out age2);
        Console.WriteLine("Your age is {0} ", age2);
        Console.ReadKey();
        
        

        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        Console.Write("Enter your age: ");
        byte age = (byte)int.Parse(Console.ReadLine());
        Console.WriteLine("Your name is {0} and age is {1} ", name, age);
        Console.ReadKey();
        

        Console.Write("Enter your name1: ");
        string name1 = Console.ReadLine();
        Console.Write("Enter your age1: ");
        byte age1 = checked((byte)int.Parse(Console.ReadLine()));
        Console.WriteLine("Your name is {0} and age is {1} ", name1, age1);
        

        Console.Write("Enter your name1: ");
        string name1 = Console.ReadLine();
        Console.Write("Enter your age1: ");
        byte age1 = checked((byte)int.Parse(Console.ReadLine()));
        Console.WriteLine("Your name is {0} and age is {1} ", name1, age1);
        Console.Write("What is your favorite day of week?");
        DayOfWeek day = (DayOfWeek) int.Parse(Console.ReadLine());
        Console.Write($"Your favorite day of week is :{day}");

        byte age4 = checked((byte)int.Parse(Console.ReadLine()));
        int intage = age4;
        Console.WriteLine("Your name is {0} and age is {1} ", name1, intage);
        */

        Console.Write("Enter your name: ");
        var name = Console.ReadLine();
        Console.Write("Enter your age: ");

        var age = checked((byte)int.Parse(Console.ReadLine()));
        Console.WriteLine("Your name is {0} and age is {1} ", name, age);

        Console.Write("What is your favorite day of week? ");

        var day = (DayOfWeek)int.Parse(Console.ReadLine());
        Console.WriteLine("Your favorite day is {0}", day);

        Console.Write("Enter your age: ");
        int age2;
        bool iscorrect = int.TryParse(Console.ReadLine(), out age2);
        Console.WriteLine("Your age is {0} ", age2);

        Console.ReadKey();
    }
}

/*
enum DaysOfWeek : byte
{
    Tuesday,
    Monday,
    Wednesday,
    Friday
}
*/

enum Semaphore 
{
    Red = 100,
    Yellow = 200,
    Green = 300
}