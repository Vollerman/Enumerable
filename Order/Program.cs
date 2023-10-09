using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> names = new List<string> { "John", "Jane", "Bob", "Alice" };

        var orderedNames = names.OrderBy(name => name);

        foreach (var name in orderedNames)
        {
            Console.WriteLine(name);
        }
    }
}