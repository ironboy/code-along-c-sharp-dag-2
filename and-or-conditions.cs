
// TODO: Read from input
int normalPriceSEK = 100;
bool isRetired = false;
bool hasDiscountCard = true;
bool employeeDiscount = true;
int age = 30;


// Ticket price on a boat ride to Ven from Landskrona
// adults 100%
// isRetired -20% 
// children -50%
// discountCard -10%
// employeeDiscount -10% (can not be combined with card)

double totalDiscount = 0;

// We require people who claim they are retired
// to be at least 25 years old
if (isRetired && age >= 25 && !employeeDiscount)
{
    totalDiscount += 0.2;
}

if (age < 16)
{
    totalDiscount += 0.5;
}

if (hasDiscountCard || employeeDiscount)
{
    totalDiscount += 0.1;
}

int priceSEK = (int)(normalPriceSEK * (1 - totalDiscount));

Console.WriteLine($"The total discount is {Math.Round(totalDiscount * 100.0)}%");
Console.WriteLine($"Your price is {priceSEK} SEK");