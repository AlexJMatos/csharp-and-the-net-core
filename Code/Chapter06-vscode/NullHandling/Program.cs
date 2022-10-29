using static System.Console;
using Packt.Shared;

// int thisCannotBeNull = 4;
// thisCannotBeNull = null;

int? thisCouldBeNull = null;

WriteLine(thisCouldBeNull);
WriteLine(thisCouldBeNull.GetValueOrDefault());

thisCouldBeNull = 7;
WriteLine(thisCouldBeNull);
WriteLine(thisCouldBeNull.GetValueOrDefault());

Address address = new();
address.Building = null;
address.Street = null;
address.City = "London";
address.Region = null;

// checking for null values
string authorName = null;
try
{
    int x = authorName.Length;
}
catch (NullReferenceException e)
{
    WriteLine("Author name was null");
}


int? y = authorName?.Length;

int result = authorName?.Length ?? 3;
WriteLine(result);

Employee john = new Employee()
{
    Name = "John Jones",
    DateOfBirth = new(year: 1990, month: 7, day: 28)
};

john.EmployeeCode = "JJ001";
john.HireDate = new(year: 2014, month: 11, day: 23);
WriteLine($"{john.Name} was hired on {john.HireDate:dd/MM/yy}");

class Address
{
    public string? Building = string.Empty;
    public string Street = string.Empty;
    public string City = string.Empty;
    public string Region = string.Empty;
}