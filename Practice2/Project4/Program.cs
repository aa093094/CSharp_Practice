string[] PIDs = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

foreach (string IDs in PIDs)
{
    if(IDs.StartsWith("B"))
    {
        Console.WriteLine(IDs);
    }
}