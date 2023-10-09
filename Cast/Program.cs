System.Collections.ArrayList fruits = new System.Collections.ArrayList
{
    "ananas",
    "grape",
    "lemon"
};

IEnumerable<string> query =
    fruits.Cast<string>().OrderBy(fruit => fruit).Select(fruit => fruit);

foreach (string fruit in query)
{
    Console.WriteLine(fruit);
}


