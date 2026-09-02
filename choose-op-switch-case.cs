Console.Write("Räknesätt (+ - * /)? ");
string op = Console.ReadLine()!;

// Most effective when want do a lot of different 
// depening on the value of a variable
// might be switch case construct
switch (op)
{
    case "+":
        Console.WriteLine("Addition, förstås.");
        break;
    case "-":
        Console.WriteLine("Subtraktion.");
        break;
    case "*":
        Console.WriteLine("Multiplikation!");
        break;
    case "/":
        Console.WriteLine("Division — se upp med noll.");
        break;
    default:
        Console.WriteLine("Okänt räknesätt.");
        break;
}

// But you can do the same using if...else if... else
if (op == "+")
{
    Console.WriteLine("Addition, förstås.");
}
else if (op == "-")
{
    Console.WriteLine("Subtraktion.");
}
else if (op == "*")
{
    Console.WriteLine("Multiplikation!");
}
else if (op == "/")
{
    Console.WriteLine("Division — se upp med noll.");
}
else
{
    Console.WriteLine("Okänt räknesätt.");
}
