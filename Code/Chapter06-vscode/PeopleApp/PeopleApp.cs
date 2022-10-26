using static System.Console;
using Packt.Shared;

Person harry = new Person() { Name = "Harry" };
Person mary = new Person() { Name = "Mary" };
Person jill = new Person() { Name = "Jill" };

// call instance method
Person baby1 = Person.Procreate(harry, mary);
baby1.Name = "Gary";

Person baby2 = harry.ProcreateWith(jill);
baby2.Name = "Jeff";

// call an operator
Person baby3 = harry * mary;

WriteLine($"{harry.Name} has {harry.Children.Count} children.");
WriteLine($"{mary.Name} has {mary.Children.Count} children.");
WriteLine($"{jill.Name} has {jill.Children.Count} children.");
WriteLine("{0}'s first child is named \"{1}\".",
harry.Name,
harry.Children[0].Name);

WriteLine($"5! is {Person.Factorial(5)}");

DelegateWithMatchingSignature d = new DelegateWithMatchingSignature(harry.MethodIWantToCall);
int answer = d("Frog");
WriteLine($"Frog length is {answer}");

// Defining and handling delegates
static void Harry_Shout(object? sender, EventArgs e)
{
    if (sender is null) return;
    Person p = (Person)sender;
    WriteLine($"{p.Name} is this angry: {p.AngerLevel}.");
}

//harry.Shout = Harry_Shout;
harry.Shout += Harry_Shout;

harry.Poke();
harry.Poke();
harry.Poke();
harry.Poke();

// non generic types
System.Collections.Hashtable lookupObject = new();

lookupObject.Add(key: 1, value: "Alpha");
lookupObject.Add(key: 2, value: "Beta");
lookupObject.Add(key: 3, value: "Gamma");
lookupObject.Add(key: harry, value: "Delta");

int key = 2; // lookup the value that has 2 as its key
WriteLine(format: "Key {0} has value: {1}", key, lookupObject[key]);
// lookup the value that has harry as its key
WriteLine(format: "Key {0} has value: {1}", harry, lookupObject[harry]);

// generic types
// generic lookup collection
Dictionary<int, string> lookupIntString = new();

lookupIntString.Add(key: 1, value: "Alpha");
lookupIntString.Add(key: 2, value: "Beta");
lookupIntString.Add(key: 3, value: "Gamma");
lookupIntString.Add(key: 4, value: "Delta");

key = 3;
WriteLine(format: "Key {0} has value: {1}", key, lookupIntString[key]);