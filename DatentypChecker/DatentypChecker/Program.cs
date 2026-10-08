Console.Write("Gib etwas ein: ");
string input = Console.ReadLine();

if (int.TryParse(input, out int intValue))
{
    Console.WriteLine($"Integer: {intValue}");
    return;
}

if (bool.TryParse(input, out bool boolValue))
{
    Console.WriteLine($"Bool: {boolValue}");
    return;
}

if (double.TryParse(input, out double doubleValue))
{
    Console.WriteLine($"Double: {doubleValue}");
    return;
}

Console.WriteLine("String"); 