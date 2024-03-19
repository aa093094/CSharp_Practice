string pangram = "The quick brown fox jumps over the lazy dog";
string[] items = pangram.Split(' ');
string result = "";

foreach (string item in items)
{
    char[] valueArray = item.ToCharArray();
    Array.Reverse(valueArray);
    string value = new string(valueArray);
    result = result + " " + value;
}

Console.WriteLine(result);
