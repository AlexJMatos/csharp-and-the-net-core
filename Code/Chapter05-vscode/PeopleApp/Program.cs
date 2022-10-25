using Packt.Shared;
using static System.Console;

Person bob = new();
bob.Name = "Alex Matos";
bob.DateOfBirth = new DateTime(1996, 11, 12);

bob.BucketList = WondersOfTheAncientWorld.HangingGardensOfBabylon | WondersOfTheAncientWorld.MausoleumAtHalicarnassus;
bob.FavoriteAncientWonder = WondersOfTheAncientWorld.TempleOfArtemisAtEphesus;

WriteLine("{0} was born on{1: dddd, d MMMM yyyy}", bob.Name, bob.DateOfBirth);
WriteLine("{0}'s favorite wonder is {1}. Its integer is {2}",
bob.Name,
bob.BucketList,
(int)bob.BucketList);

bob.Children.Add(new Person { Name = "Alfred" });
bob.Children.Add(new() { Name = "Zoe" });

WriteLine($"{bob.Name} has {bob.Children.Count} children");

foreach (Person child in bob.Children)
{
    WriteLine($"{child.Name}");
}

BankAccount.InterestRate = 0.012M;

BankAccount alexAccount = new BankAccount();
alexAccount.AccountName = "Mr. Alex Matos";
alexAccount.Balance = 2400;

WriteLine(format: "{0} earned {1:C} interest.",
alexAccount.AccountName,
alexAccount.Balance * BankAccount.InterestRate);

BankAccount miriamAccount = new BankAccount();
miriamAccount.AccountName = "Mrs. Miriam Matos";
miriamAccount.Balance = 98;

WriteLine(format: "{0} earned {1:C} interest.",
miriamAccount.AccountName,
miriamAccount.Balance * BankAccount.InterestRate);

WriteLine($"{bob.Name} is a {Person.Species}");
WriteLine($"{bob.Name} was born on {bob.HomePlanet}");

Person blankPerson = new();
WriteLine(format:
"{0} of {1} was created at {2:hh:mm:ss} on a {2:dddd}.",
blankPerson.Name,
blankPerson.HomePlanet,
blankPerson.Instantiated);

Person gunny = new(initialName: "Gunny", homePlanet: "Mars");
WriteLine(format:
"{0} of {1} was created at {2:hh:mm:ss} on a {2:dddd}.",
gunny.Name,
gunny.HomePlanet,
gunny.Instantiated);

bob.WriteToConsole();
WriteLine(bob.GetOrigin());

(string, int) fruit = bob.GetFruit();
WriteLine($"{fruit.Item1}, {fruit.Item2} there are.");

var fruitNamed = bob.GetNamedFruit();
WriteLine($"There are {fruitNamed.Number} {fruitNamed.Name}.");

var thing1 = ("Neville", 4);
WriteLine($"{thing1.Item1} has {thing1.Item2} children.");

var thing2 = (bob.Name, bob.Children.Count);
WriteLine($"{thing2.Name} has {thing2.Count} children.");

(string fruitName, int fruitNumber) = bob.GetFruit();
WriteLine($"Deconstructed: {fruitName}, {fruitNumber}");

// Deconstructing a Person
var (name1, dob1) = bob;
WriteLine($"Deconstructed: {name1}, {dob1}");

var (name2, dob2, fav2) = bob;
WriteLine($"Deconstructed: {name2}, {dob2}, {fav2}");

// passing parameters
WriteLine(bob.SayHello());
WriteLine(bob.SayHello("Pancho"));

// optional parameters
WriteLine(bob.OptionalParameters());
WriteLine(bob.OptionalParameters("Jump", 98.5));