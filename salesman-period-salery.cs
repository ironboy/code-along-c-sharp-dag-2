/*
En försäljare har delvis prestationslön.
Han får 8000 kr per månad i grundlön och 9% av försäljningssumman.
Skriv en funktion som beräknar lönesumman under en period.
Försäljningssumman ska läsas in.
*/

// Function that gets the monthly sales in SEK
// and calculates the salary in SEK
static int MonthlySalaryInSEK(double salesInSEK, int numberOfMonths)
{
    return numberOfMonths * 8000 + (int)Math.Round(salesInSEK * 0.09);
}

// Test the function with user input
Console.Write("How many months of salary should we count? ");
int months = int.Parse(Console.ReadLine()!);

Console.Write("What's your sales in SEK during this period? ");
double sales = double.Parse(Console.ReadLine()!);

int total = MonthlySalaryInSEK(sales, months);

Console.WriteLine($"Your monthly salary is {total}");