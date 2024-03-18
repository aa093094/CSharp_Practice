string[] values = { "12.3", "45", "ABC", "11", "DEF" };
float sum = 0;
string message = "";

foreach (string value in values)
{
    float result = 0; 
    if (float.TryParse(value, out result))
    {
        sum += result;
    }
    else
    {
        message += value;
    }
}

Console.WriteLine($"Message: {message}");
Console.WriteLine($"Total: {sum}");
