Console.Write("What's your name? ");
string? name = Console.ReadLine();

// if...else (tradtional) - two options
if (name == "Thomas")
{
    Console.WriteLine("Thomas is the most beautiful name in the world!");
}
else if (name == "Benjamin")
{
    Console.WriteLine("That's a unusual name!");
}
else
{
    Console.WriteLine($"{name} is a nice name!");
}

// as a ternary operator ("villkorsoperator")
// condition ? valueIfConditionWasTrue : valueIfConditionWasFalse

Console.WriteLine(
    name == "Thomas" ?
    "Thomas is the most beautiful name in the world!" :
    name == "Benjamin" ?
    "Thats' an unusal name!" :
    $"{name} is a nice name!"
 );