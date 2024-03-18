string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int periodLocation;

for (int i = 0; i < 2; i++)
{
    string myString = myStrings[i];
    periodLocation = myString.IndexOf('.');

    while (periodLocation != -1)
    {
        string modifiedString = myString.Remove(periodLocation);
        string subString = myString.Substring(periodLocation + 1);

        Console.WriteLine(modifiedString.TrimStart());
        periodLocation = subString.IndexOf('.');
        myString = subString;
    }

    Console.WriteLine(myString.TrimStart());
}
