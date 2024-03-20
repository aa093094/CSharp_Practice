const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

string openingWord = "<span>";
string closingWord = "</span>";
int openingLength = openingWord.Length;
 
int openingPosition = input.IndexOf(openingWord) + openingLength;
int closingPosition = input.IndexOf(closingWord);
int length = closingPosition - openingPosition;
quantity = input.Substring(openingPosition, length); 

openingWord = "<div>";
closingWord = "</div>";
string targetWord = "&trade;";
string replaceWord = "&reg;";
openingLength = openingWord.Length;

openingPosition = input.IndexOf(openingWord) + openingLength;
closingPosition = input.IndexOf(closingWord);
length = closingPosition - openingPosition;
output = input.Substring(openingPosition, length);
output = output.Replace(targetWord, replaceWord);

Console.WriteLine("Quantity: " + quantity);
Console.WriteLine("Output: " + output);
