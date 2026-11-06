using System.Globalization;


string str = "1 sdfsdf";

int a;

bool result = int.TryParse(str, out a);

Console.WriteLine(result);

Console.ReadLine();