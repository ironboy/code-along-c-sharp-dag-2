/*
    It's common when you program
    that you want to change the value
    of a variable
    (add, subtract, multiple, divide etc)
    there a longer and shorter syntaxes for this
    
    We explain all of them below but
    CHOOSE THE SHORTEST POSSIBLE SYNTAX
    when you program
*/

int counter = 1;

// -------- ADDING ---------------

Console.WriteLine(counter);

// Add 1 to counter - the long way
counter = counter + 1;

Console.WriteLine(counter);

// Add 1 to counter - the short way
counter += 1;

Console.WriteLine(counter);

// Add 1 to counter - the shortest way
// only works when add exactly 1
counter++;

Console.WriteLine(counter);

// Add 2 to counter - the long way
counter = counter + 2;

Console.WriteLine(counter);

// Add 2 to counter - the short way
counter += 2;

Console.WriteLine(counter);


// -------- SUBTRACTING ---------------

// Subtract 1 to counter - the long way
counter = counter - 1;

Console.WriteLine(counter);

// Subtract 1 to counter - the short way
counter -= 1;

Console.WriteLine(counter);

// Subtract 1 to counter - the shortest way
// only works when Subtract exactly 1
counter--;

Console.WriteLine(counter);

// Subtract 2 to counter - the long way
counter = counter - 2;

Console.WriteLine(counter);

// Subtract 2 to counter - the short way
counter -= 2;

Console.WriteLine(counter);

// Multiplication - long way
counter = counter * 2;

Console.WriteLine(counter);

// Multiplication - short way
counter *= 2;

Console.WriteLine(counter);

// Division - long way
counter = counter / 2;

Console.WriteLine(counter);

// Division - short way
counter /= 2;

Console.WriteLine(counter);

// The + operator can be used with strings too
// this is called string concatenation
string a = "Hej ";
string b = "då";

a += b; // could have been writen a = a + b

Console.WriteLine(a);