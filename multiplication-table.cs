// Nested loops (loops inside loops)
// A small example with only two levels

// The important to understand
// The inner loop repeats until condition is false
// Then the outer loop can continue...

for (int i = 1; i <= 12; i++)
{
    Console.WriteLine("");
    Console.WriteLine($"{i}:ans tabell");
    Console.WriteLine("--------------");
    for (int j = 1; j <= 12; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}");
    }
}