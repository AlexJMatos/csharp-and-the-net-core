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
WriteLine(bob.OptionalParameters(number: 52.7, command: "Hide!"));
WriteLine(bob.OptionalParameters("Poke!", active: false));

// parameters: by value, by reference, out parameter
int a = 10;
int b = 20;
int c = 30;
WriteLine($"Before: a = {a}, b = {b}, c = {c}");
bob.PassingParameters(a, ref b, out c);
WriteLine($"After: a = {a}, b = {b}, c = {c}");

// simplyfing out parameters
int d = 10;
int e = 20;

WriteLine($"Before: d = {d}, e = {e}, f doesn't exists yet!");
bob.PassingParameters(d, ref e, out int f);
WriteLine($"After: d = {d}, e = {e}, f = {f}");

// Definition in partial class PersonAutoGen
Person sam = new()
{
    Name = "Sam",
    DateOfBirth = new(1972, 1, 27)
};

WriteLine(sam.Origin);
WriteLine(sam.Greeting);
WriteLine(sam.Age);

sam.FavoriteIceCream = "Chocolate Fudge";
WriteLine($"Sam's favorite ice-cream flavor is {sam.FavoriteIceCream}.");
sam.FavoritePrimaryColor = "Red";
WriteLine($"Sam's favorite primary color is {sam.FavoritePrimaryColor}.");

sam.Children.Add(new() { Name = "Charlie" });
sam.Children.Add(new() { Name = "Ella" });
WriteLine($"Sam's first child is {sam.Children[0].Name}");
WriteLine($"Sam's second child is {sam.Children[1].Name}");
WriteLine($"Sam's first child is {sam[0].Name}");
WriteLine($"Sam's second child is {sam[1].Name}");

object[] passengers = {
new FirstClassPassenger { AirMiles = 1_419 },
new FirstClassPassenger { AirMiles = 16_562 },
new BusinessClassPassenger(),
new CoachClassPassenger { CarryOnKG = 25.7 },
new CoachClassPassenger { CarryOnKG = 0 },
};

foreach (object passenger in passengers)
{
    /*decimal flightCost = passenger switch
    {
        FirstClassPassenger p when p.AirMiles > 35000 => 1500M,
        FirstClassPassenger p when p.AirMiles > 15000 => 1750M,
        FirstClassPassenger _ => 2000M,
        BusinessClassPassenger _ => 1000M,
        CoachClassPassenger p when p.CarryOnKG < 10.0 => 500M,
        CoachClassPassenger _ => 650M,
        _ => 800M
    };*/
    decimal flightCost = passenger switch
    {
        /* C# 8 syntax
        FirstClassPassenger p when p.AirMiles > 35000 => 1500M,
        FirstClassPassenger p when p.AirMiles > 15000 => 1750M,
        FirstClassPassenger => 2000M, */
        // C# 9 or later syntax
        /*FirstClassPassenger p => p.AirMiles switch
        {
            > 35000 => 1500M,
            > 15000 => 1750M,
            _ => 2000M
        },*/
        FirstClassPassenger { AirMiles: > 35000 } => 1500,
        FirstClassPassenger { AirMiles: > 15000 } => 1750M,
        FirstClassPassenger => 2000M,
        BusinessClassPassenger => 1000M,
        CoachClassPassenger p when p.CarryOnKG < 10.0 => 500M,
        CoachClassPassenger => 650M,
        _ => 800M
    };
    WriteLine($"Flight costs {flightCost:C} for {passenger}");

    // init properties
    ImmutablePerson jeff = new()
    {
        FirstName = "Jeff",
        LastName = "Bradley"
    };

    /* throws error CS8852: Init-only property or indexer
    'ImmutablePerson.FirstName' can only be assigned in an object initializer,
    or on 'this' or 'base' in an instance constructor or an 'init' accessor.*/
    //jeff.FirstName = "Geoff";
}

ImmutableVehicle car = new()
{
    Brand = "Mazda MX-5 RF",
    Color = "Soul Red Crystal Metallic",
    Wheels = 4
};

ImmutableVehicle repaintedCar = car with { Color = "Polymetal Grey Metallic" };

WriteLine($"Original car color was {car.Color}");
WriteLine($"New car color is {repaintedCar.Color}");

// deconstruct records
ImmutableAnimal pancho = new("Oscar", "Chihuahua");
var (who, what) = pancho;
WriteLine($"{who} is a {what}");