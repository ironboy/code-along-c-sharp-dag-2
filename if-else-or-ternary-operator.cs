Console.Write("What's your name? ");
string? name = Console.ReadLine();

// if...else (tradtional) - two options
if (name == "Thomas")
{
    Console.WriteLine("Thomas is the most beautiful name in the world!");
}
else
{
    Console.WriteLine($"{name} is a nice name!");
}

// as a ternary operator ("villkorsoperator")
// condition ? valueIfConditionWasTrue : valueIfConditionWasFalse

// Useful when we are just choosing between different values
// but if-clauses can have a lot of logic a programming
// inside a program block...

Console.WriteLine(name == "Thomas" ?
"Thomas is the most beautiful name in the world!" :
 $"{name} is a nice name!");