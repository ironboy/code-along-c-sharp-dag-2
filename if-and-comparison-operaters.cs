
// Declare the variable ageAsString here
// so its available everywhere in this file
using System.Data;

string? ageAsString; // null
int age; // 0
bool firstTry = true;

// do...while is a loop
// do a thing once
// then check if a condition is true
// while the condition do it again... and again
do
{
    if (!firstTry)
    {
        Console.WriteLine("Jag förstod inte ditt svar. Svara med siffror och ett icke-negativt tal!");
    }
    Console.Write("Hur gammal är du? ");
    // Change the variable ageAsString to t
    // the user input here
    // if we had declared it here it would
    // only be available inside this program blcok
    ageAsString = Console.ReadLine();
    // Set firstTry to false so we know the 
    // next iteration that first answer failed
    firstTry = false;
} while (!int.TryParse(ageAsString, out age) || age < 0);
// the condition in while is a combination of
// - continue to loop if we can convert ageAsString to an int
// - or if age is less than 0

// When you use if..else if..else
// if one condition in is true then the rest of the same if..else if...else
// will never be run even if there a more conditions furhter down are true

if (age < 18)
{
    Console.WriteLine("Du är inte myndig och får inte handla på Systembolaget");
}
else if (age < 20)
{
    Console.WriteLine("Du får inte handla på Systembolaget, men du får lov att rösta!");
}
else
{
    Console.WriteLine("Du får handla på Systembolaget, för du är minst 20 år gammal.");
}