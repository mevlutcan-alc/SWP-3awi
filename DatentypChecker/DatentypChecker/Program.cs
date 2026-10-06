Console.Write("Gib etwas ein: ");
string input = Console.ReadLine();

if (int.TryParse(input, out int intValue))
{
    Console.WriteLine($"Integer: {intValue}");
}
else if (bool.TryParse(input, out bool boolValue))
{
    Console.WriteLine($"Bool: {boolValue}");
}
else if (double.TryParse(input, out double doubleValue))
{
    Console.WriteLine($"Double: {doubleValue}");
}
else
{
    Console.WriteLine("String");
}