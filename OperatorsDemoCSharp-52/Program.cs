using System.Threading.Channels;

namespace OperatorsDemoCSharp_52;

class Program
{
    static void Main(string[] args)
    {
        //operators
        
        //assignment operator =

        //int x = 5;
        
        //arithmetic operators

        int addition = 5 + 5;
        int subtraction = 5 - 5;
        int multiplication = 5 * 5;
        int division = 5 / 5;
        int modulus = 6 % 5; //remainder after division
        
        //bool isEven = 6 % 2 == 0;
        
        //unary operators

        int x = 3;
        int y = ++x; //pre increment

        Console.WriteLine(x);
        Console.WriteLine(y);

        int a = 3;
        int b = a++; //post increment

        Console.WriteLine(a);
        Console.WriteLine(b);

        int c = 5;
        Console.WriteLine(--c); //pre decrement

        int d = 5;
        Console.WriteLine(d--); //post decrement
        Console.WriteLine(d);
        
        //relational operators

        bool isEqual = 5 == 5;
        bool isNotEqual = 5 != 5;
        bool isGreaterThan = 5 > 5;
        bool isLessThan = 5 < 5;
        bool isGreaterThanOrEqualTo = 5 >= 5;
        bool isLessThanOrEqualTo = 5 <= 5;
        
        //logical operators

        bool resultOne = 5 == 5 && 7 == 7;
        bool resultTwo = 5 == 5 || 7 == 5;
        
        //null coalescing operator

        int? possiblyNullValue = 1000;
        int notNullValue = possiblyNullValue ?? 500;
        Console.WriteLine(notNullValue);

        int number = 10;

        number += 5;

        Console.WriteLine(number);
    }
}