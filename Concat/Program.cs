using System;
namespace Concat;
class Program
{
    static void Main()
    {
        string firstName = "John";
        string lastName = "Doe";

        string fullName = string.Concat(firstName, " ", lastName);

        Console.WriteLine(fullName); // Output: John Doe
    }
}





