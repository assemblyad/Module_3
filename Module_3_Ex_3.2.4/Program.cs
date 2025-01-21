using System;
using System.Data;
using System.Drawing;
using System.Numerics;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

static class StringExtension
{
    public static char GetLastChar(this string source)
    {
        return source[source.Length - 1];
    }
}

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
        

        Console.Write("Enter your name: ");
        var name = Console.ReadLine();
        Console.Write("Enter your age: ");

        var age = checked((byte)int.Parse(Console.ReadLine()));
        Console.WriteLine("Your name is {0} and age is {1} ", name, age);

        Console.Write("What is your favorite day of week? ");

        var day = checked((DayOfWeek)int.Parse(Console.ReadLine()));
        Console.WriteLine("Your favorite day is {0}", day);

        Console.Write("Enter your age: ");
        int age2;
        bool iscorrect = int.TryParse(Console.ReadLine(), out age2);
        Console.WriteLine("Your age is {0} ", age2);
        
        var myapples = 5;
        var hisapples = 6;
        var hispeares = 5;

        var result = (myapples != hispeares) & (myapples < hisapples);

        Console.WriteLine(result);
        Console.ReadKey();

        var a = 5 + 6;
        var b = 7 + 8;

        var c = (b != a) & (b > a + 1);
        var d = (b != a) && (b > a + 1);

        Console.WriteLine(c);
        Console.WriteLine(d);
        var a = 5 + 6;
        var b = 7 + 8;

        var c = (b == a) & (b > a + 1);
        var d = (b == a) && (b > a + 1);

        Console.WriteLine(c);
        Console.WriteLine(d);

        var inv = true;
        var result = !inv;

        var a = 6;
        var b = 7;

        if (a == b)
        {
            Console.WriteLine("Условие истинно");
        }
        else
        {
            Console.WriteLine("Условие ложно");
        }

        var a = 6;
        var b = 7;

        if (a == b)
        {
            Console.WriteLine("Условие истинно");
        }
        else if (b < 10)
        {
            Console.WriteLine("Значение b = {0} меньше 10", b);
        }
        else
        {
            Console.WriteLine("Значение b = {0} больше 10", b);
        }

        var a = 6;
        var b = 7;

        if (a == b && b > 1)
        {
            Console.WriteLine("Условие истинно");
        }

        else if (b > 10 || b == 7)
        {
            Console.WriteLine("Значение b = {0} больше 10 или равно 7", b);
        }
        else
        {
            Console.WriteLine("Значение b = {0}", b);
        }

        var a = 6;
        var b = 7;

        var c = a != b ? a + b : b;

        Console.WriteLine("Write your favorite color in English using low cap");

        var color = Console.ReadLine();

        if (color == "red")
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.WriteLine("Your color is red!");
        }

        else if (color == "green")
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.WriteLine("Your color is green!");
        }
        else
        {
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.WriteLine("Your color is cyan!");
        }

        var color = Console.ReadLine();

        switch (color)
        {
            case "red":
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is red!");
                break;

            case "green":
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is green!");
                break;
            case "cyan":
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is cyan!");
                break;


            default:
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine("Your color is cyan!");
                break;
        }

        Console.WriteLine("Loop while");
        int k = 0;

        while (k < 3)
        {
            Console.WriteLine(k);

            Console.WriteLine("Write your favorite color in English using low cap");
            switch (Console.ReadLine())
            {
                case "red":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is red!");
                    break;

                case "green":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is green!");
                    break;
                case "cyan":
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is cyan!");
                    break;


                default:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("Your color is cyan!");
                    break;
            }

            k++;

        }

        Console.WriteLine("Loop do While");
        int t = 0;

        do
        {
            Console.WriteLine(t);
            Console.WriteLine("Write your favorite color in English using low cap");

            switch (Console.ReadLine())
            {
                case "red":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is red!");
                    break;

                case "green":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is green!");
                    break;
                case "cyan":
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is cyan!");
                    break;
                default:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("Your color is yellow!");
                    break;
            }

            t++;
        } while (t < 3);

        Console.WriteLine("Loop while");
        int k = 0;

        while (k < 1)
        {
            Console.WriteLine("Write your favorite color in English using low cap");
            Console.WriteLine(k);

            var text = Console.ReadLine();

            switch (Console.ReadLine())
            {
                case "red":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is red!");
                    break;

                case "green":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is green!");
                    break;
                case "cyan":
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is cyan!");
                    break;
                default:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("Your color is yellow!");
                    break;
            }

            k++;
            if (text == "stop")
            {
                Console.WriteLine("Цикл остановлен");
                break;
            }

        }

        Console.WriteLine("Loop do while");
        int t = 0;

        do
        {
            Console.WriteLine(t);

            Console.WriteLine("Write your favorite color in English using low cap");
            switch (Console.ReadLine())
            {
                case "red":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is red!");
                    break;

                case "green":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is green!");
                    break;
                case "cyan":
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is cyan!");
                    break;
                default:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("Your color is yellow!");
                    break;
            }

            t++;
        } while (t < 1);

        Console.WriteLine("Loop while");
        int k = 0;

        while (k < 1)
        {
            Console.WriteLine("Write your favorite color in English using low cap");
            Console.WriteLine(k);

            var text = Console.ReadLine();

            if (text == "stop")
            {
                Console.WriteLine("Цикл остановлен");
                break;
            }

            switch (text)
            {
                case "red":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is red!");
                    break;

                case "green":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is green!");
                    break;

                case "cyan":
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is cyan!");
                    break;
                default:
                    continue;
            }

            k++;
        }

        int sum = 0;

        while (true)
        {
            Console.WriteLine("Enter a number");
            var number = Convert.ToInt32(Console.ReadLine());

            if (number < 0)
            {
                continue;
            }
            else if (number == 0)
            {
                break;
            }

            // number > 0
            sum += number;
        }

        Console.WriteLine("Итоговая сумма: {0}", sum);


        //Размерность массива 
        var arr = new int[] { 1, 2, 3, 4 };
        var l = arr.Length;

        //Разные виды инициализации массива
        int[] arr1 = new int[4] { 1, 2, 3, 5 };
        int[] arr2 = new int[] { 1, 2, 3, 5 };
        int[] arr3 = new[] { 1, 2, 3, 5 };
        int[] arr4 = { 1, 2, 3, 5 };

        var numbers = new int[] { 6, 30, 7, 14, 2, 15 };
        int minValue = 100000,
        minIndex = -1;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] < minValue)
            {
                minValue = numbers[i];
                minIndex = i;
            }
        }

        Console.WriteLine("The minimum array value index is {0}, and value of the element is = {1}", minIndex, numbers[minIndex]);

        Console.ReadKey();
        Console.WriteLine("Enter your name");

        var name = Console.ReadLine();

        string[] nameOpposite = new string[name.Length];


        Console.WriteLine("Ваше имя по буквам: ");

        foreach (var ch in name)
        {
            Console.Write(ch + " ");
        }

        Console.WriteLine("The last letter in your name is : {0}", name[name.Length - 1]);


        Console.WriteLine("Enter your name");

        var name = Console.ReadLine();
         
        Console.WriteLine("Enter your name: ");

        for (int i = name.Length-1 ;i>=0 ; i--)
        {
            Console.Write(name[i] + " ");
        }

        Console.WriteLine("The last letter in your name is : {0}", name[name.Length - 1]);

        int[,] array = { { 1, 2, 3, 4, 5, 6 }, { 5, 6, 7, 4, 5, 6 } , { 5, 6, 7, 4, 5, 6 } };
        //Console.WriteLine(array[0, 0]);
        /*
        foreach (var item in array)
        {
            Console.Write(item + " ");
        }

        Console.WriteLine(array.Length);
        Console.WriteLine(array.GetUpperBound(1));

        int[,] array = { { 1, 2, 3 }, { 5, 6, 7 } };
        Console.Write("Number of rows: ");
        Console.WriteLine(array.GetUpperBound(0) + 1 + " ");

        Console.Write("Number of columns: ");
        Console.WriteLine(array.GetUpperBound(1) + 1 + " ");

        int[,] array = { { 1, 2, 3 }, { 5, 6, 7 }, { 8, 9, 10 }, { 11, 12, 13 } };

        for (int i = 0; i < array.GetUpperBound(0) + 1; i++)
        {
            for (int k = 0; k < array.GetUpperBound(1) + 1; k++)
                Console.Write(array[i, k] + " ");

            Console.WriteLine();
        }

        int[,] array = { { 1, 2, 3 }, { 5, 6, 7 }, { 8, 9, 10 }, { 11, 12, 13 } };

        for (int i = 0; i < array.GetUpperBound(1) + 1; i++)
        {
            for (int k = 0; k < array.GetUpperBound(0) + 1; k++)
                Console.Write(array[k, i] + " ");

            Console.WriteLine();
        }


        var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };
        int temp;


        for (int i = 0; i <arr.Length ; i++)
        {
            for (int j = i + 1; j < arr.Length; j++) { 
                
                if (arr[i] > arr[j])
                {
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

        }

        foreach (var item in arr)
        {
            Console.Write(item);
        }

        int sum = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }

        string[] favcolors = new string[3];

        for (int i = 0; i < favcolors.Length; i++)
        {
            Console.WriteLine("Enter your favorite color {0}", i + 1);
            favcolors[i] = Console.ReadLine();
        }

        foreach (var color in favcolors)
        {
            switch (color)
            {
                case "red":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is red!");
                    break;

                case "green":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is green!");
                    break;

                case "cyan":
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is cyan!");
                    break;
                default:
                    continue;
            }
        }

        int[][] array = new int[3][];

        array[0] = new int[2] { 1, 2 };
        array[1] = new int[3] { 1, 2, 3 };
        array[2] = new int[5] { 1, 2, 3, 4, 5 };

        foreach (var num in array)
        {
            foreach (var item in num)
            {
                Console.Write(item + " ");
            }
        }

        var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };
        int positiveNumberCount=0;


        for (int i = 0; i < arr.Length; i++)
        {
            if ( arr[i] > 0 ) { }
            {
                positiveNumberCount++;
            }

        }

        Console.Write(positiveNumberCount);

        //Давайте модифицируем нашу предыдущую задачу для работы с двумерным массивом. Необходимо найти количество положительных элементов массива.
        int[,] arr = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };
        int positiveNumberCount = 0;


        for (int i = 0; i < arr.GetUpperBound(0) + 1; i++)
        {
            for (int k = 0; k < arr.GetUpperBound(1) + 1; k++)

            if (arr[i, k] > 0) 
            {
                positiveNumberCount++;
            }
        }

        Console.Write(positiveNumberCount);

        int[,] arr = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };

        int positiveNumberCount = 0;


        foreach (var item in arr)
        {
            if (item > 0)
            {
                positiveNumberCount++;
            }
        }

        Console.Write(positiveNumberCount);

        int[][] array = new int[3][];

        array[0] = new int[2] { 1, 2 };
        array[1] = new int[3] { 1, 2, 3 };
        array[2] = new int[5] { 1, 2, 3, 4, 5 };


        foreach (var num in array)
        {
            foreach (var item in num)
            {
                Console.Write(item + " ");
            }
        }

        int[,] arr = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };

        foreach (var num in arr)
        {
            foreach (var item in num)
            {
                Console.Write(item + " ");
            }
        }

        //Задание 4.3.17


        int[,] arr = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };
        int temp;

        for (int y = 0; y < arr.GetUpperBound(0)+1; y++)
        {
            for (int k = 0; k < arr.GetUpperBound(1)+1; k++)
            {
                for(int x = k+1; x< arr.GetUpperBound(1) + 1; x++)
                {
                    if (arr[y, k] > arr[y, x])
                    {
                        temp = arr[y, x ];
                        arr[y, x] = arr[y, k];
                        arr[y, k] = temp;
                    }
                }     
            }
        }


        for (int i = 0; i < arr.GetUpperBound(0) + 1; i++)
        {
            for (int k = 0; k < arr.GetUpperBound(1) + 1; k++)
                Console.Write(arr[i, k] + " ");

            Console.WriteLine();
        }













        /*
        for (int i = 0; i < arr.GetUpperBound(0) + 1; i++)
        {
            for (int k = 0; k < arr.GetUpperBound(1) + 1; k++)
            {
                for (int j = k + 1; j < arr.GetUpperBound(1) + 1; j++)
                {
                    if (arr[i,k] > arr[i,j])
                    {
                        temp = arr[i, j];
                        arr[i, j] = arr[i, k];
                        arr[i, k] = temp;
                    }
                }
            }
            Console.Write("\n");
        }

        for (int i = 0; i < arr.GetUpperBound(0) + 1; i++)
        {
            for (int k = 0; k < arr.GetUpperBound(1) + 1; k++)
                Console.Write(arr[i, k] + " ");

            Console.WriteLine();
        }

        //Console.Write(positiveNumberCount);
        //var anketa = (name: "Jane", age: 27);
        var (name, age) = ("Alexander", 27);
        Console.WriteLine("Your name: {0}", name);
        Console.WriteLine("Your age: {0}", age);

        Console.Write("Enter your name: ");
        name = Console.ReadLine();
        Console.Write("Enter your age:");
        age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Your name: {0}", name);
        Console.WriteLine("Your age: {0}", age);

        (string Name, string Type, double Age) Pet;

        Console.Write("Your Pet's name: ");
        Pet.Name = Console.ReadLine();

        Console.Write("Your Pet's type: ");
        Pet.Type = Console.ReadLine();

        Console.Write("Your Pet's age: ");
        Pet.Age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Your Pet's name: {0}", Pet.Item1);
        Console.WriteLine("Your Pet's type: {0}", Pet.Item2);
        Console.WriteLine("Your Pet's age: {0}", Pet.Item3);

        (string Name, string Type, double Age, int NameCount) Pet;

        Console.Write("Your Pet's name: ");
        Pet.Name = Console.ReadLine();
        Pet.NameCount = Pet.Name.Length;

        Console.Write("Your Pet's type: ");
        Pet.Type = Console.ReadLine();

        Console.Write("Your Pet's age: ");
        Pet.Age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Your Pet's name: {0}", Pet.Item1);
        Console.WriteLine("Your Pet's type: {0}", Pet.Item2);
        Console.WriteLine("Your Pet's age: {0}", Pet.Item3);
        Console.WriteLine("Your Pet's age: {0}", Pet.Item4);

        (string Name, string LastName, string Login, int LoginLength,
                bool HasPet, string[] favcolors, double Age) User;
        for (int k = 0; k < 0; k++)
        {
            Console.WriteLine("Enter name");
            User.Name = Console.ReadLine();

            Console.WriteLine("Enter last name");
            User.LastName = Console.ReadLine();

            Console.WriteLine("Enter login name");
            User.Login = Console.ReadLine();

            User.LoginLength = User.Name.Length;
            Console.WriteLine($"The user name length is {0}", User.LoginLength);

            Console.WriteLine("Do you have pets? yes or No");
            User.HasPet = Console.ReadLine() == "yes" ? true : false;

            Console.WriteLine("Enter user's age: ");
            User.Age = Convert.ToDouble(Console.ReadLine());

            User.favcolors = new string[3];

            Console.WriteLine("Enter three favorite colors :");
            for (int i = 0; i < User.favcolors.Length; i++)
            {
                User.favcolors[i] = Console.ReadLine();
            }
        }

        (string Name, string[] Dishes) User;
        Console.WriteLine("\nEnter user name: ");
        User.Name = Console.ReadLine();

        Console.WriteLine("\nEnter your 5 favorite dishes : ");
        User.Dishes = new string[5];
        for (int i = 0; i < User.Dishes.Length; i++)
        {
            Console.WriteLine($"Enter your dish favorite name: {i + 1} ");
            User.Dishes[i] = Console.ReadLine();
        }

        var (name, age) = ("Alexander", 27);

        Console.WriteLine("My name: {0}", name);
        Console.WriteLine("My age: {0}", age);

        Console.Write("Enter your name: ");
        name = Console.ReadLine();
        Console.Write("Enter your age using number:");
        age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Your name: {0}", name);
        Console.WriteLine("Your age: {0}", age);


        string [] favorcolors = new string[3];

        for (int i = 0; i < favorcolors.Length; i++)
        {
            favorcolors[i] = ShowColor();
        }

        for (int i = 0; i < favorcolors.Length; i++)
        {
            Console.WriteLine($"You entered favorite color : {i+1} " + favorcolors[i]);
        }

        int[] arrayFromConsole = new int[5];
        arrayFromConsole = GetArrayFromConsole();
        arrayFromConsole = sortArray(arrayFromConsole);
        for (int i = 0; i < arrayFromConsole.Length; i++)
        {
            Console.WriteLine(arrayFromConsole[i]);
        }
       
        //(string name, int age) anketa;

        var (name, age) = ("Alexander", 27);

        Console.Write("Enter your name: ");
        name = Console.ReadLine();
        Console.Write("Enter your age:");
        age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Your name: {0}", name);
        Console.WriteLine("Your age: {0}", age);

        //Задание 5.2.8

        string[] favorcolors = new string[3];

        for (int i = 0; i < favorcolors.Length; i++)
        {
            favorcolors[i] = ShowColor(name, age);
        }

        ShowColors(favcolor: favorcolors);
        /*
        for (int i = 0; i < favorcolors.Length; i++)
        {
            favorcolors[i] = ShowColor(name, age);
        }
        

        //Задание 5.2.15
        var array = GetArrayFromConsole();
        var sortedarray = SortArray(array);

        //Задание 5.2.16
        var array1 = GetArrayFromConsole(3);
        var sortedarray1 = SortArray(array);

        //Задание 5.2.17
        var array2 = GetArrayFromConsole(10);
        ShowArray(array2, true);
        //Module 5.3
        var someName = "Alexander";
        Console.WriteLine(someName);

        ChangeName(ref someName);
        Console.WriteLine(someName);
        
        var myAge = 45;
        Console.WriteLine(myAge);

        ChangeAge(myAge);
        Console.WriteLine(myAge);


        var arr = new int[] { 1, 2, 3 };
        int data = 5;
        BigDataOperation(arr, ref data);

        Console.WriteLine(arr[0]);

        //Задание 5.3.8
        var someName = "Alexander";
        var oldNameTest = "oldName";
        Console.WriteLine(someName);
        Console.WriteLine(oldNameTest);
        GetName(out someName,out oldNameTest);
        Console.WriteLine(someName);
        Console.WriteLine(oldNameTest);

        Console.WriteLine("Write something: ");

        var str = Console.ReadLine();

        Console.WriteLine("Specify eco deep");

        var deep = int.Parse(Console.ReadLine());

        Echo(str, deep);

        Console.WriteLine("Enter desired factorial: ");
        int factorial = int.Parse(Console.ReadLine());

        decimal reuslt = Factorial(factorial);

        Console.WriteLine("Factorial of entered number {0} eqaul to the {1} ", factorial, reuslt);

        var num = 1;

        AddTen(ref num);

        Console.WriteLine(num);

        int num1 = 100;
        int numNum = num;


        object obj = 200;
        object newobj = obj;

        Animal animal = new Animal { type = "dog", name = "Volt", age = "4" };

        Data data = new Data { Name = "Record", Lenght = 10, Version = 1, Array = new int[] {15,20 } };
        Obj obj = new Obj { Name = "Table", IsAlive = false, Weight = 15 };

        var dataCopy = data;
        var objCopy = obj;


        data.Name = "Value";
        data.Version = 2;
        data.Array[0] = 0;

        obj.Name = "Cat";
        obj.IsAlive = true;
        obj.Weight = 3;

        objCopy = new Obj { Name =objCopy.Name, IsAlive = obj.IsAlive, Weight = obj.Weight };

        obj.Name = "Table";
        obj.IsAlive = false;
        obj.Weight = 15;

        var department = GetCurrentDepartment();

        User user = new User();

        // private Setter
        //user.Age = 10;

        // Getter
        Console.WriteLine(user.Age);

        Car car = new HybridCar();
        car.Move();

        SmartHelper helper = new SmartHelper("Олег");
        helper.Greetings("Грег");

        //BaseClass baseClass = new BaseClass();
        //BaseClass baseClass1 = new DerivedClass();
        //baseClass.Display();  //Задание 7.2.3
        //baseClass1.Display(); //Задание 7.2.3
        //DerivedClass obj = new DerivedClass();
        DerivedClass obj = new DerivedClass();
        obj.Display();

        A a = new A();
        B b = new B();
        C c = new C();

        a.Display();    // метод класса A
        b.Display();    // метод класса B
        ((A)b).Display();   // метод класса B

        c.Display();    // метод класса C
        ((A)c).Display();   // метод класса B
        ((B)c).Display();	// метод класса B

        var array = new Book[]
        {
            new Book
            {
              Name = "Мастер и Маргарита",
              Author = "М.А. Булгаков"
            },
            new Book
            {
              Name = "Отцы и дети",
              Author = "И.С. Тургенев"
            },
        };

        BookCollection collection = new BookCollection(array);

        Book book = collection[1];
        
        //Counter counter = new Counter();
        Counter.IncreasingCouter++;
        Console.WriteLine(Counter.IncreasingCouter);
        */
        Order<int> order1 = new Order<int>();
        Order<string> order2 = new Order<string>();
        order1.Number = 1234;
        order2.Number = "NN-1234";

        Generic<object, int, string> generic = new Generic<object, int, string>();

        Console.ReadKey();
    }
    //Задание 7.6.6
    class Record<T1, T2>
    {
        public T1 Id;
        public T2 Value;
        public DateTime Date;
    }
    class Obj2
    {
        public void Display<T>(T param)
        {
            Console.WriteLine(param.ToString());
        }
    }
    class Program
    {
        public static void Swap<T>(ref T x, ref T y)
        {
            T t = x;
            x = y; 
            y = t;
        }
    }

    //Задание 7.6.2
    abstract class Car<TEngine> where TEngine: Engine
    {
        public TEngine Engine = default(TEngine);
        public abstract void ChangePart<TPart>(TPart newPart) where TPart : CarPart;

    }
    class ElectricEngine: Engine
    {

    }
    class GasEngine: Engine
    {

    }
    class Battery: CarPart
    {

    }
    class Differential: CarPart
    {

    }
    class Wheel: CarPart
    {

    }
    abstract class Engine
    {

    }
    abstract class CarPart
    {

    }
    class ElectricCar: Car<ElectricEngine>
    {
        public override void ChangePart<TPart>(TPart newPart)
        {
            
        }
    }
    class GasCar: Car<GasEngine>
    {
        public override void ChangePart<TPart>(TPart newPart)
        {

        }
    }
    class Generic<T1, T2,T3>
    {
        public T1 Field;
        public T2 Property { get; set; }
        public void Mehtod (T3 param)
        {

        }
    }

    class Generic<T>
    {
        public T Field;
        public void Method(T param)
        {

        }
    }
    class Order<T>
    {
        public T Number;
        public string Description;

    }
    //Задание 7.5.13
    class Helper
    {

        public static void Swap(ref int num1, ref int num2)
        {
            int tempNum;
            tempNum = num1;
            num1 = num2;
            num2 = num1;
        }
    }




    class ObjWthStatic
    {
        private string name;
        private string Description;
        public static int MaxValue = 200;
    }
    class Counter
    {
        private static int increasingCouter;
        public static int IncreasingCouter
        {
            get 
            { 
                return increasingCouter; 
            }
            set
            {
                if (value > increasingCouter)
                { 
                    increasingCouter= value;
                }
            }
        }
    }
    abstract class Transport
    {
        public abstract void Move();
    }

    class Boat : Transport
    {
        public override void Move()
        {
            // ...
        }
    }

    class Car : Transport
    {
        public double Fuel;

        public int Mileage;

        public Car()
        {
            Fuel = 50;
            Mileage = 0;
        }
        public override void Move()
        {
            Mileage++;
            Fuel -= 0.5;
        }

        public void FillTheCar()
        {
            Fuel = 50;
        }
    }
    class HybridCar : Car
    {
        public FuelType FuelType;

        public void ChangeFuelType(FuelType type)
        {
            FuelType = type;
        }
    }


    abstract class ComputerPart
    {
        public string Name;

        public ComputerPart(string name)
        {
            Name = name;
        }

        public abstract void Work();
    }
    class Processor: ComputerPart
    {
        public Processor(string name): base (name)
        {

        }
        public override void Work()
        {

        }
    }
    class MotherBoard: ComputerPart
    {
        public MotherBoard(string name) : base(name)
        {

        }
        public override void Work()
        {

        }

    }
    class GraphicCard: ComputerPart
    {
        public GraphicCard(string name) : base(name)
        {

        }
        public override void Work()
        {

        }

    }
    abstract class FourLeggedAnimal
    {
        public abstract string Name
        {
            get;
            set;
        }
    }

    class Dog : FourLeggedAnimal
    {
        private string name;
        public override string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
    }

    class Cat : FourLeggedAnimal
    {
        public override string Name
        {
            get;
            set;
        }
    }
    abstract class Person
    {
        public string Name;

        public Person(string name)
        {
            Name = name;
        }

        public void DisplayName()
        {
            Console.WriteLine(Name);
        }
    }

    class Employee : Person
    {
        // Булевый флаг, сообщающий, находится ли сотрудник на смене
        public bool IsOnShift;

        public Employee(string name, bool isOnShift) : base(name)
        {
            IsOnShift = isOnShift;
        }
    }

    class Guest : Person
    {
        // Дата и время прибытия гостя
        public DateTime ArrivalDate;

        public Guest(string name, DateTime arrivalDate) : base(name)
        {
            ArrivalDate = arrivalDate;
        }
    }



    //Задание 7.2.14
    class IndexingClass
    {
        private int[] array;

        public IndexingClass(int[] array)
        {
            this.array = array;
        }

        public int this[int index]
        {
            get
            {
                return array[index];
            }
            set
            {
                array[index] = value;
            }
        }
    }

    // Класс для объекта “Книга”
    class Book
    {
        public string Name;
        public string Author;
    }

    // Класс для объекта “Коллекция книг”
    class BookCollection
    {
        // Закрытое поле, хранящее книги в виде массива
        private Book[] collection;

        // Конструктор с добавлением массива книг
        public BookCollection(Book[] collection)
        {
            this.collection = collection;
        }

        // Индексатор по массиву
        public Book this[int index]
        {
            get
            {
                // Проверяем, чтобы индекс был в диапазоне для массива
                if (index >= 0 && index < collection.Length)
                {
                    return collection[index];
                }
                else
                {
                    return null;
                }
            }

            private set
            {
                // Проверяем, чтобы индекс был в диапазоне для массива
                if (index >= 0 && index < collection.Length)
                {
                    collection[index] = value;
                }
            }
        }
    }
    //Задание 7.2.12
    class Obj
    {
        public int Value;

        public static Obj operator +(Obj a, Obj b)
        {
            return new Obj
            {
                Value = a.Value + b.Value
            };
        }
        public static Obj operator -(Obj a, Obj b)
        {
            return new Obj
            {
                Value = a.Value - b.Value
            };
        }
    }


    class A
    {
        public virtual void Display()
        {
            Console.WriteLine("A");
        }
    }
    class B : A
    {
        public new void Display() { Console.WriteLine("B"); }   
    }
    class C : A
    {
        public override void Display() { Console.WriteLine("C"); }
    }
    class D : B    
    {
        public new void Display()
        {
            Console.WriteLine("D");
        }
    }
    class E : C 
    {
        public new void Display()
        {
            Console.WriteLine("E");
        }
    }




    /*
    class A
    {
        public virtual void Display()
        {
            Console.WriteLine("Method called by class A");
        }
    }
    class B : A
    {
        public override void Display()
        {
            Console.WriteLine("Method called by class B");
        }
    }
    class C : B
    {
        public new void Display()
        {
            Console.WriteLine("Method called by class C");
        }
    }
    */
    /*
    //Задание 7.2.4
    class BaseClass
    {
        public virtual int Counter
        {
            get;
            set;
        }
    }

    class DerivedClass : BaseClass
    {
        public override int Counter
        {
            get
            {
                return Counter;
            }
            set
            {
                if (value >= 0) 
                {
                    Counter = value;
                }
            }
        }
    }
    */
    class Citizen
    {
        public virtual double Age
        {
            get;
            set;
        }

        public void SayYourAge()
        {
            Console.WriteLine("Мне {0} лет", Age);
        }
    }

    class CivilServant : Citizen
    {
        private double age;
        public override double Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value < 18)
                {
                    Console.WriteLine("Для работы госслужащим гражданин должен быть не младше 18 лет");
                }
                else
                {
                    age = value;
                }
            }
        }
    }

    class President : CivilServant
    {
        private double age;
        public override double Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value < 35)
                {
                    Console.WriteLine("Для работы президентом гражданин должен быть не младше 35 лет");
                }
                else
                {
                    age = value;
                }
            }
        }
    }

    
    //Задание 7.2.3
    class BaseClass
    {
        public virtual void Display()
        {
            Console.WriteLine("Method of class BaseClass");
        }
    }
    class DerivedClass: BaseClass
    {
        public override void Display()
        {
            base.Display();
            Console.WriteLine("Method of DerivedClass");
        }
    }

    class Creature { }

    class Animal : Creature { }

    class Human : Creature { }

    class HomoSapiens : Human { }
    /*
    class Program
    {
        static void Main(string[] args)
        {
            HomoSapiens hs = new HomoSapiens();
            Human human = hs;
            Creature creature = (Creature)human;
            Creature secondCreature = new Animal();
        }
    }
    
    //Задание 7.1.10
    class BaseClass
    {
        protected string Name;

        public BaseClass(string name)
        {
            Name = name;
        }
    }
    class DerivedClass : BaseClass
    {
        public string Description;

        public int Counter;

        DerivedClass(string name,string description): base(name)
        {
            Description = description;
        }
        public DerivedClass(string name, string description, int counter) : this(name, description)
        {
            Counter = counter;
        }
    }

    
    class BaseClass
    {
        public string Name;
        protected string Description;
        private int value;

        public BaseClass(int value)
        {
            this.value = value;
        }
    }

    class InheritedClass : BaseClass
    {
        private int newValue;

        public InheritedClass(int newValue) : base(100)
        {
            this.newValue = newValue;
        }
    }
    */
    //Задание 7.1.6
    class Obj1
    {
        private string name;
        private string owner;
        private int length;
        private int count;

        public Obj1(string name, string ownerName, int objLength, int count)
        {
            this.name = name;
            owner = ownerName;
            length = objLength;
            this .count = count;
        }
    }
    //Задание 7.1.7
    class SmartHelper
    {
        private string name;

        public SmartHelper(string name)
        {
            this.name = name;
        }
        public void Greetings(string name)
        {
            Console.WriteLine("Привет, {0}, я интеллектуальный помощник {1}", name, this.name);
        }
    }
    /*
    class Employee
    {
        public string Name;
        public int Age;
        public int Salary;
    }
    class ProjectManager: Employee
    {
        public string ProjectName;
    }
    */
    class Food
    {

    }
    class Fruit : Food
    {

    }
    class Vegetable: Food
    {

    }
    class Apple: Fruit
    {

    }
    class Banana: Fruit
    {

    }
    class Pear: Fruit
    {

    }
    class Potato: Vegetable
    {

    }
    class Carrot: Vegetable
    {

    }
    /*
    class Developer: Employee
    {
        private string ProgrammingLanguage;
    }
    
    class BaseClass
    {
        public string Name;
        protected string Description;
        private int value;
    }

    class InheritedClass : BaseClass
    {

    }
    */
    class User
    {
        private int age;
        private string loginName;
        private string emailAddress;
        private DateTime lastSeen;
        public int Age
        {
            get
            {
                return age;
            }

            private set
            {
                if (value < 18)
                {
                    Console.WriteLine("The entered age cannot be less than 18");
                }
                else
                {
                    age = value;
                }
            }
        }
        public string LoginName
        {
            get
            {
                return loginName;
            }
        }
        public string EmailAddress
        {
            get
            {
                return emailAddress;
            }
            set
            {
                if (!value.Contains("@"))
                {
                    Console.WriteLine("The enter valid e mail address");
                }
                else
                {
                    emailAddress = value;
                }
            }
        }
        public DateTime LastSeen
        {
            set
            {
                lastSeen = value;
            }
        }
    }

    class TrafficLight
    {
        private string Color;
        private void ChangeColor(string color)
        {

        }
        public string GetColor()
        {
            return Color;
        }
    }

    enum TurnDirection
    {
        None = 0,
        Left,
        Right
    }
/*
    class Car
    {
        public double Fuel;

        public int Mileage;

        public Car()
        {
            Fuel = 50;
            Mileage = 0;
        }

        public virtual void Move()
        {
            // Move a kilometer
            Mileage++;
            Fuel -= 0.5;
        }

        public void FillTheCar()
        {
            Fuel = 50;
        }
    }
*/
    enum FuelType
    {
        Gas = 0,
        Electricity
    }
/*
    class HybridCar : Car
    {
        public FuelType FuelType;
        private double Gas {  get; set; }
        private double Electricity {  get; set; }



        public override void Move()
        {
            base.Move();
            Console.WriteLine("Вызван метод Move класса HybridCar");

            switch (FuelType)
            {
                case FuelType.Gas:
                    Gas -= 0.5;
                    break;
                case FuelType.Electricity:
                    Electricity -= 0.5;
                    break;
            }
        }

        public void ChangeFuelType(FuelType type)
        {
            FuelType = type;
        }
    }
*/
    static Department GetCurrentDepartment()
    {

        Department department = new Department();

        string message = department?.Company?.Name == "Bank" && department?.City?.Name == "Peter" ? "The bank has branch at Peter" : "No branch found at that city";
        /*
            if (department?.Company?.Type == "Банк" && department?.City?.Name == "Санкт-Петербург")
            {
	            Console.WriteLine("У банка {0} есть отделение в Санкт-Петербурге", department?.Company?.Name ?? "Неизвестная компания");
            }
        */          

        return department;
        // logic
    }

    class Triangle
    {
        public int sideA;

        public int sideB;

        public int sideC;


        public void Square()
        {
            // Move a kilometer
        }

        public void Perimiter()
        {

        }
    }
    class Circle
    {
        public double radius;

        public double? lenght;

        public Circle()
        {
            radius = 0;
            lenght = 0;
        }
        public void Square()
        {
            // Move a kilometer
        }

        public void Perimiter()
        {

        }
    }
    class Square
    {
        public int sideA;

        public void Square1()
        {
            // Move a kilometer
        }
        public void Perimiter()
        {

        }
    }
    class Bus
    {
        public int? Load;

        public void PrintStatus()
        {
            if (Load.HasValue && Load > 0)
            {
                Console.WriteLine("В авбтобусе {0} пассажиров", Load.Value);
            }
            else
            {
                Console.WriteLine("Автобус пуст!");
            }
        }
    }
    class Company
    {
        public string Type;
        public string Name;
    }
    class Department
    {
        public Company Company;
        public City City;
    }
    class City
    {
        public string Name;
    }



    struct Data
    {
        public string Name;
        public int Lenght;
        public int Version;
        public int[] Array;
    }
    /*
    class Obj
    {
        public string Name;
        public bool IsAlive;
        public int Weight;
    }
    */


    class Rectabgle
    {
        public int a;
        public int b;
        Rectabgle()
        {
            a = 6;
            b= 4;
        }

        Rectabgle(int first, int second)
        {
            a = first;
            b = second;
        }
        Rectabgle(int side)
        {
            a = side;
            b = side;
        }

        public int Square() { return a * b; }

    }
    /*
    struct Animal
    {
        public string type;
        public string name;
        public string age;

        public void Info()
        {
            Console.WriteLine("It is {0} with nick name {1}, he is {2}", type, name, age);
        }
    }
    */
    class Pen
    {
        public string color;
        public int cost;

        Pen()
        {
            color = "black";
            cost = 100;
        }
        Pen(string penColor, int penCcost)
        {
            color = penColor;
            cost = penCcost;
        }
    }
    static void AddTen(ref int num)
    {
        num = num + 10;
    }
    public static int PowerUp(int N, byte pow)
    {
        if (pow == 0)
        {
            return 1;
        }
        else
        {
            if (pow == 1)
            {
                return N;
            }
            else
            {
                return N * PowerUp(N, --pow);
            }
        }
    }
    static void Echo(string saidWorld, int deep)
    {
        var modif = saidWorld;
        if (modif.Length>2) 
        {
            modif = modif.Remove(0,2);
        }

        Console.BackgroundColor = (ConsoleColor)deep;
        Console.WriteLine("..." + modif);

        if (deep > 1)
        {
            Echo(modif, deep - 1);
        }
    }
    static decimal Factorial(int x)
    {
        if (x == 0)
        {
            return 1;
        }
        else
        {
            return x * Factorial(x - 1);
        }
    }
    /*
    static void Echo(string phrase, int deep)
    {
        Console.WriteLine(phrase);

        if (deep > 1)
        {
            Echo(phrase, deep - 1);
        }
    }
    */
        static void BigDataOperation(in int[] arr, ref int data)
    {
        data = 4;
        arr[0] = 4;
    }
    static void ChangeName(ref string name)
    {
        Console.WriteLine("Enter name");
        name = Console.ReadLine();
    }
    static void ChangeAge(int age)
    {
        Console.WriteLine("Enter new age");
        age = Convert.ToInt32(Console.ReadLine());
    }
    static void GetName(out string name, out string oldName)
    {
        oldName = "Alexander old name";
        Console.WriteLine("Enter name");
        name = Console.ReadLine();
    }

    static void GetAge(out string Name, out byte Age)
    {
        Name = "";
        Age = 0;
    }
    /*
    static int SumNumbers(ref int num1, in int num2, out int num3, int num4 )
    {
        num1 = 5;
        result = num1 + num2;
        num3 = num3 * result;
        return result;
    }
    

    static void ShowArray(int[] array, bool IsSort= false)
    {
        var temp = array;

        if(IsSort)
        {
            var sortedarray2 = SortArray(array);
        }
        
        foreach( var item in temp)
        {
            Console.WriteLine(item);
        }
    }
    */

    //Задание 5.2.14
    //Задание 5.2.14
    static int[] GetArrayFromConsole(ref int num )
    {
        var result = new int[num];

        for (int i = 0; i < result.Length; i++)
        {
            Console.WriteLine("Enter array element {0}", i + 1);
            result[i] = int.Parse(Console.ReadLine());
        }

        return result;
    }
    static int[] SortArrayAsc(int [] result)
    {
        int temp;

        for (int i = 0; i < result.Length; i++)
        {
            for (int j = i + 1; j < result.Length; j++)
            {
                if (result[i] > result[j])
                {
                    temp = result[i];
                    result[i] = result[j];
                    result[j] = temp;
                }
            }
        }

        return result;
    }
    static int [] SortArrayDesc(int[] result)
    {
        int temp;

        for (int i = 0; i < result.Length; i++)
        {
            for (int j = i + 1; j < result.Length; j++)
            {
                if (result[i] < result[j])
                {
                    temp = result[i];
                    result[i] = result[j];
                    result[j] = temp;
                }
            }
        }

        return result;
    }
    static void SortArray(in int[] array, out int[] sorteddesc, out int[] sortedasc)
    {
        sorteddesc = SortArrayDesc(array);
        sortedasc = SortArrayAsc(array);
    }

    static string GetDataFromConsole() => Console.ReadLine();

    static string ShowColor(string userName, int userAge)
    {
        Console.WriteLine("{0}, {1} years old \nEnter your your favorite color using low caps ", userName, userAge);
        var color = Console.ReadLine();

        switch (color)
        {
            case "red":
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is red!");
                break;

            case "green":
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is green!");
                break;
            case "cyan":
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is cyan!");
                break;
            default:
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine("Your color is yellow!");
                break;
        }

        return color;
    }
    
    static void ShowColors(string userName = "Jane", params string[] favcolor)
    {
        Console.WriteLine("{0} ,Your favorite colors",userName);

        foreach (var fav in favcolor)
        {
            Console.WriteLine($"{fav}");
        }

    }
    static string ShowColor(string[] favcolors)
    {
        //Console.WriteLine("{0}, {1} years old \nEnter your your favorite color using low caps ", userName, userAge);
        var color = Console.ReadLine();

        switch (color)
        {
            case "red":
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is red!");
                break;

            case "green":
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is green!");
                break;
            case "cyan":
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is cyan!");
                break;
            default:
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine("Your color is yellow!");
                break;
        }

        return color;
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