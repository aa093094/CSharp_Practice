string[,] corporate = 
{
    {"Robert", "Bavin"}, {"Simon", "Bright"},
    {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
    {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
};

string[,] external = 
{
    {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
    {"Shay", "Lawrence"}, {"Daren", "Valdes"}
};

string externalDomain = "hayworth.com";

for (int i = 0; i < corporate.GetLength(0); i++) 
{
    DisplayEmail("corporate", i);
}

for (int i = 0; i < external.GetLength(0); i++) 
{
    DisplayEmail("external", i);
}

void DisplayEmail(string where, int i)
{
    if (where == "corporate")
    {
        string name = corporate[i, 0].Substring(0, 2).ToLower();
        string lastName = corporate[i, 1].ToLower();
        Console.WriteLine($"{name}{lastName}@contoso.com");
    }
    else if (where == "external")
    {
        string name = external[i, 0].Substring(0, 2).ToLower();
        string lastName = external[i, 1].ToLower();
        Console.WriteLine($"{name}{lastName}@{externalDomain}");
    }
}