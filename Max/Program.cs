double?[] doubles = { null, 1.5E+104, 9E+103, -2E+103 };

double? max = doubles.Max();

Console.WriteLine("The largest number is {0}.", max);

/*
 This code produces the following output:

 The largest number is 1.5E+104.
*/