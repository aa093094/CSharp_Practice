using System.Globalization;

string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

Console.WriteLine($"Dear {customerName},");
Console.WriteLine($"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.");
Console.WriteLine($"\nCurrently, you own {currentShares:N2} shares at a return of {currentReturn:P2}.");
Console.WriteLine($"\nOur new product, {newProduct} offers a return of {newReturn:P2}. Given your current volume, your potential profit would be {newProfit:C}.");
Console.WriteLine("");

Console.WriteLine("Here's a quick comparison:\n");

string comparisonMessage = "";

comparisonMessage += currentProduct.PadRight(20);
comparisonMessage += String.Format("{0:P2}  {1:C}", currentReturn, currentProfit);
comparisonMessage += "\n";
comparisonMessage += newProduct.PadRight(20);
comparisonMessage += String.Format("{0:P2}  {1:c}", newReturn, newProfit);

Console.WriteLine(comparisonMessage);
