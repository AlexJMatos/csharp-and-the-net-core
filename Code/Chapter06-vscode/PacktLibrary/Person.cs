using static System.Console;

namespace Packt.Shared;
public class Person : IComparable<Person>
{
    // fields
    public string? Name;
    public DateTime DateOfBirth;
    public List<Person> Children = new();
    // public EventHandler? Shout;
    public event EventHandler? Shout;
    public int AngerLevel;

    // methods
    public void Poke()
    {
        AngerLevel++;
        if (AngerLevel >= 3)
        {
            // if something is listening...
            if (Shout != null)
            {
                // ...then call the delegate
                Shout(this, EventArgs.Empty);
            }
        }
    }

    public void WriteToConsole()
    {
        WriteLine($"{Name} was born on a {DateOfBirth:dddd}.");
    }

    // static methods to multiply
    public static Person Procreate(Person p1, Person p2)
    {
        Person baby = new()
        {
            Name = $"Baby of {p1.Name} and {p2.Name}"
        };

        p1.Children.Add(baby);
        p2.Children.Add(baby);

        return baby;
    }

    public Person ProcreateWith(Person partner)
    {
        return Procreate(this, partner);
    }

    // operator to "multiply"
    public static Person operator *(Person p1, Person p2)
    {
        return Person.Procreate(p1, p2);
    }

    // local functions
    public static int Factorial(int number)
    {
        if (number < 0)
        {
            throw new ArgumentException($"{nameof(number)} cannot be less than zero");
        }
        return localFactorial(number);

        int localFactorial(int localNumber)
        {
            if (localNumber < 1) return 1;
            return localNumber * localFactorial(localNumber - 1);
        }
    }

    public int MethodIWantToCall(string input)
    {
        return input.Length;
    }

    public int CompareTo(Person? other)
    {
        if (Name is null) return 0;
        return Name.CompareTo(other?.Name);
    }

    public void TimeTravel(DateTime when)
    {
        if (when <= DateOfBirth)
        {
            throw new PersonException("If you travel back in time to a date" +
            "earlier than your own birth, then the universe will explode!");
        }
        else
        {
            WriteLine($"Welcome to {when:yyyy}!");
        }
    }
}

// delegates
public delegate int DelegateWithMatchingSignature(string s);