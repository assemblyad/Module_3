using System;
using System.Data;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

class MainClass
{
    public static void Main(string[] args)
    {
        (string Name, string LastName, int Age, string[] Pet, string[] Favcolor) User;

        User = EntereUser();

        ShowDetailedUsersAnketa(User);

    }

    static void ShowDetailedUsersAnketa((string Name, string LastName, int Age, string[] Pet, string[] Favcolor) user)
    {
        Console.Write("\nUser's name is {0}:", user.Name);
        Console.Write("\nUser's last name is {0}:", user.LastName);
        Console.Write("\nUser's age is {0}:", user.Age);

        if (user.Pet.Length > 0)
        {
            Console.WriteLine("\nYou have {0} pets", user.Pet.Length);
            for (int i = 0; i < user.Pet.Length; i++)
            {
                Console.WriteLine($"Your pet name number {0} is {1}:",i+1, user.Pet[i]);
            }
        }

        if (user.Favcolor.Length > 0)
        {
            Console.WriteLine("\nPou have {0} favorite colors", user.Favcolor.Length);
            for (int i = 0; i < user.Pet.Length; i++)
            {
                Console.WriteLine($"Your favorite color number  {i + 1} is {user.Favcolor[i]}:");
            }
        }
    }

    private static (string Name, string LastName, int Age, string[] Pet, string[] Favcolor) EntereUser()
    {
        (string Name, string LastName, int Age, string[] Pet, string[] Favcolor) User;

        bool IsCorrData;
        string StringNumber ;
        int IntNumber;
        User.Pet = null;

        do
        {
            Console.WriteLine("Enter your first name using only letters :");
            User.Name = Console.ReadLine();

            IsCorrData = Checknum(in User.Name, out IntNumber);

            if (IsCorrData)
            {
                break;
            }
        }
        while (!IsCorrData) ;


        do
        {
            Console.WriteLine("Enter user last name: ");
            User.LastName = Console.ReadLine();

            IsCorrData = Checknum(in User.LastName, out IntNumber);

            if (IsCorrData)
            {
                break;
            }
        }
        while (!IsCorrData) ;


        do
        {
            Console.WriteLine("Enter user age using only full number :");
            StringNumber = Console.ReadLine();
            IsCorrData = Checknum(in StringNumber, out IntNumber);

            if (IntNumber == 0)
            {
                Console.WriteLine("Use only numbers and numbers must be greater than zero, please reenter data: ");
                continue;
            }
            else
            {
                break;
            }
        }
        while (IsCorrData);

        User.Age = IntNumber;


        Console.WriteLine("Do you have pets? yes or No");
        bool HasPet = Console.ReadLine().ToLower() == "yes" ? true : false;
        
        if (HasPet)
        {
            do
            {
                Console.WriteLine("How many pets at household? Use only full positive number to enter:");
                StringNumber = Console.ReadLine();

                IsCorrData = Checknum(in StringNumber, out IntNumber);

                if (IntNumber == 0)
                {
                    Console.WriteLine("Use only numbers and numbers must be greater than zero, please reenter data: ");
                    continue;
                }else 
                {
                    break;
                }

            } while (IsCorrData);

            User.Pet = CreateArrayWithProvidedUsage(IntNumber, "pet");
        }

        do
        {
            Console.WriteLine("How many favorite colors do you have: ");
            StringNumber = Console.ReadLine();

            IsCorrData = Checknum(StringNumber, out IntNumber);

            if (IntNumber == 0)
            {
                Console.WriteLine("Use only numbers and numbers must be greater than zero, please reenter data: ");
                continue;
            }
            else 
            {
                break;
            }

        } while (IsCorrData);

        User.Favcolor = CreateArrayWithProvidedUsage(IntNumber, "color");

        return User;
    }

    static string [] CreateArrayWithProvidedUsage(int num, string usage)
    {
        string [] result = new string[num];

        for (int i = 0; i < num; i++)
        {
            Console.WriteLine("Enter {0} name : {1}", usage,  i + 1);
            result[i] = Console.ReadLine();
        }

        return result;
    }

    static bool Checknum(in string number, out int corrnumber)
    {
        corrnumber = 0;

        if (int.TryParse(number, out int intnum))
        {
            if (intnum > 0)
            {
                corrnumber = intnum;
                return false;
            }
        }
        else
        {
            corrnumber = 0;
            return true;
        }

        return false;
    }
}