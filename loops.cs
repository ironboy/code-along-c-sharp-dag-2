// We can count from 1 to 10
// using while loops, do..while loops and for loops
// but we would probably choose a for loop
// since while and do..while have no real
// advantage - unless we don't know how
// many times we want to loop
// for examole depending user input inside the loop

// Count from 1 to 10 using a while loop
int counter = 1;

while (counter <= 10)
{
    Console.WriteLine(counter);
    counter++;
}

// An alternative use of while with break
counter = 1;
while (true)
{
    Console.WriteLine(counter);
    // you can break out of a loop using break
    if (counter == 10)
    {
        break;
    }
    counter++;
}

// Do while (the loop runs at least once)
counter = 1;
do
{
    Console.WriteLine(counter);
    counter++;
} while (counter <= 10);

// For loop
// declare variable with initial value ; condition ; change to variable
// Note: i only exist in the loop block
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(i);
}

// If you want a for loop to exist outside the loop block
// declare it outside the for-loop
int count;
for (count = 1; count <= 10; count++)
{
    Console.WriteLine(count);
}
Console.WriteLine($"The variable count exists here too and is {count}");
