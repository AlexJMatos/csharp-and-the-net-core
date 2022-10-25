// See https://aka.ms/new-console-template for more information
int numberOfApples = 12;
decimal pricePerApples = 0.35M;

Console.WriteLine(format: "{0} apples costs {1:C}",
arg0: numberOfApples,
arg1: pricePerApples * numberOfApples);

string formatted = string.Format(format: "{0} apples costs {1:C}",
arg0: numberOfApples,
arg1: pricePerApples * numberOfApples);

Console.WriteLine(formatted);

Console.WriteLine($"{numberOfApples} apples costs {pricePerApples * numberOfApples:C}");

const string firstname = "Omar";
const string lastname = "Rudberg";
const string fullname = $"{firstname} {lastname}";

Console.WriteLine(fullname);

string applesText = "Apples";
int applesCount = 1234;

string bananasText = "Bananas";
int bananasCount = 56789;

Console.WriteLine(
format: "{0,-10} {1,6:N0}",
arg0: "Name",
arg1: "Count");

Console.WriteLine(
format: "{0,-10} {1,6:N0}",
arg0: applesText,
arg1: applesCount);

Console.WriteLine(
format: "{0,-10} {1,6:N0}",
arg0: bananasText,
arg1: bananasCount);

Console.Write("Type your first name and press ENTER: ");
string? firstName = Console.ReadLine();

Console.Write("Type your age and press ENTER: ");
string? age = Console.ReadLine();

Console.WriteLine($"Hello {firstName}, you look good for {age}!");

Console.Write("Press any key combination: ");
ConsoleKeyInfo key = Console.ReadKey();
Console.WriteLine();
Console.WriteLine("Key: {0}, Char: {1}, Modifiers: {2}",
arg0: key.Key,
arg1: key.KeyChar,
arg2: key.Modifiers);