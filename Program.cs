
using System.Collections;
using System.Net.WebSockets;
using System.Runtime.InteropServices;

public class Program
{
    int number;
    int num1;
    int num2;
    int num3;
    char letter;
    int dayCode;
    public static void Main(string[] args)
    {
        int times = 1000;
        CheckForPositiveNegativeZero(-1);
        Thread.Sleep(times);
        Console.Clear();
        CheckForPositiveNegativeZero(1);
        Thread.Sleep(times);
        Console.Clear();
        CheckForPositiveNegativeZero(0);
        Thread.Sleep(times);
        Console.Clear();
        FindMinimum(1, 2, 3);
        Thread.Sleep(times);
        Console.Clear();
        FindMinimum(2, 1, 3);
        Thread.Sleep(times);
        Console.Clear();
        FindMinimum(3, 2, 1);
        Thread.Sleep(times);
        Console.Clear();
        FindMaximum(1, 2, 3);
        Thread.Sleep(times);
        Console.Clear();
        FindMaximum(2, 1, 3);
        Thread.Sleep(times);
        Console.Clear();
        FindMaximum(3, 2, 1);
        Thread.Sleep(times);
        Console.Clear();
        IsDivisibleBy5(5);
        Thread.Sleep(times);
        Console.Clear();
        IsDivisibleBy5(6);
        Thread.Sleep(times);
        Console.Clear();
        CheckEvenOrOdd(2);
        Thread.Sleep(times);
        Console.Clear();
        CheckEvenOrOdd(3);
        Thread.Sleep(times);
        Console.Clear();
        CheckVowelOrConsonant('e');
        Thread.Sleep(times);
        Console.Clear();
        CheckVowelOrConsonant('E');
        Thread.Sleep(times);
        Console.Clear();
        CheckVowelOrConsonant('s');
        Thread.Sleep(times);
        Console.Clear();
        CheckVowelOrConsonant('S');
        Thread.Sleep(times);
        Console.Clear();
        DisplayDayOfWeek(0);
        Thread.Sleep(times);
        Console.Clear();
        DisplayDayOfWeek(3);
        Thread.Sleep(times);
        Console.Clear();
        DisplayDayOfWeek(6);
        Thread.Sleep(times);
        Console.Clear();

        CheckForPositiveNegativeZero(-1);
        CheckForPositiveNegativeZero(1);
        CheckForPositiveNegativeZero(0);
        FindMinimum(1, 2, 3);
        FindMinimum(2, 1, 3);
        FindMinimum(3, 2, 1);
        FindMaximum(1, 2, 3);
        FindMaximum(2, 1, 3);
        FindMaximum(3, 2, 1);
        IsDivisibleBy5(5);
        IsDivisibleBy5(6);
        CheckEvenOrOdd(2);
        CheckEvenOrOdd(3);
        CheckVowelOrConsonant('e');
        CheckVowelOrConsonant('E');
        CheckVowelOrConsonant('s');
        CheckVowelOrConsonant('S');
        DisplayDayOfWeek(0);
        DisplayDayOfWeek(3);
        DisplayDayOfWeek(6);
        
        // FahrenheitToCelsius(68); // Test FahrenheitToCelsius Function with a random value
        // Thread.Sleep(1000);
        // Console.Clear();
        // FindMinimum(7, 17, 28);

        // FindMaximum(28, 15, 98283);

        // CheckEvenOrOdd(13);
        // Test your functions by calling them below:
        // CheckForPositiveNegativeZero(-1); // This should output: "Your number is negative"
        // CheckForPositiveNegativeZero(0); // This should output: "Your number is zero"
        // CheckForPositiveNegativeZero(1); // This should output: "Your number is positive"
        // ...
        // ...
        // DisplayDayOfWeek(0); // This should output: "Thursday"

    }

    public static void FahrenheitToCelsius(double fahrenheit)
    {
        double celsiusDegree = (fahrenheit - 32) * 5/9; 
        Console.WriteLine($"{fahrenheit} degrees Fahrenheit is {celsiusDegree} degrees Celsius.");
    }

    // Define your functions below:
    public static void CheckForPositiveNegativeZero(int Number)
    {
        bool NumberIsPositive = Number > 0;
        bool NumberIsNegative = Number < 0; 
        if (NumberIsPositive)
        {
            Console.WriteLine("Your number is positive");
        }
        else if (NumberIsNegative)
        {
            Console.WriteLine("Your number is negative");
        }
        else
        {
            Console.WriteLine("Your number is zero");
        }
    }
    public static void FindMinimum(int num1, int num2, int num3)
    {
        if (num1 < num2 && num1 < num3)
        {
            Console.WriteLine($"Your maximum number is {num1}");
        }
        else if (num2 < num1 && num2 < num3)
        {
            Console.WriteLine($"Your maximum number is {num2}");
        }
        else if (num3 < num1 && num3 < num2)
        {
            Console.WriteLine($"Your maximum number is {num3}");
        }
        else
        {
            Console.WriteLine("Two of your numbers are the same.");
        }
    }
    public static void FindMaximum(int num1, int num2, int num3)
    {
        if (num1 > num2 && num1 > num3)
        {
            Console.WriteLine($"Your minimum number is {num1}");
        }
        else if (num2 > num1 && num2 > num3)
        {
            Console.WriteLine($"Your minimum number is {num2}");
        }
        else if (num3 > num1 && num3 > num2)
        {
            Console.WriteLine($"Your minimum number is {num3}");
        }
        else
        {
            Console.WriteLine("Two of your numbers are the same.");
        }
    }
    public static void IsDivisibleBy5(int number)
    {   
        if (number % 5 == 0)
        {
            Console.WriteLine($"{number} is divisible by 5");
        }
        else
        {
            Console.WriteLine($"{number} is not divisible by 5");
        }
    }
    public static void CheckEvenOrOdd(int number)
    {
        if (number % 2 == 0)
        {
            Console.WriteLine($"{number} is even");
        }
        else if(number == 0)
        {
            Console.WriteLine("{number} is neutral");
        }
        else 
        {
            Console.WriteLine($"{number} is odd");
        }
    }
    public static void CheckVowelOrConsonant(char letter)
    {
        switch (letter)
        {
            case 'a':
            case 'A':
            case 'e':
            case 'E':
            case 'i':
            case 'I':
            case 'o':
            case 'O':
            case 'u':
            case 'U':
            Console.WriteLine($"{letter} is a vowel.");
            break;

            default:
            Console.WriteLine($"{letter} is a consonant");
            break;
        }
    }
    public static void DisplayDayOfWeek(int dayCode)
    {
        switch (dayCode)
        {
            case 0:
            Console.WriteLine("Sunday");
            break;
            
            case 1:
            Console.WriteLine("Monday");
            break;

            case 2:
            Console.WriteLine("Tuesday");
            break;
            
            case 3:
            Console.WriteLine("Wednesday");
            break;

            case 4:
            Console.WriteLine("Thursday");
            break;

            case 5:
            Console.WriteLine("Friday");
            break;
            
            case 6:
            Console.WriteLine("Saturday");
            break;
            default:
            Console.WriteLine("Please enter a valid input (0-6)");
            break;
        }
        
    }
    
}
