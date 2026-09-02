// A function declare
static string NiceFormat(int unpadded)
{
    // convert unpaded an int to a string
    string str = unpadded.ToString();
    // if the string has a length (number of characters)
    // less than 2 then add the character 0 first
    if (str.Length < 2) { str = "0" + str; }
    // return the string
    return str;
}


for (int hours = 0; hours < 24; hours++)
{
    for (int minutes = 0; minutes < 60; minutes++)
    {
        for (int seconds = 0; seconds < 60; seconds++)
        {
            Console.WriteLine($"{NiceFormat(hours)}:{NiceFormat(minutes)}:{NiceFormat(seconds)}");
        }
    }
}