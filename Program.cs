Console.WriteLine("Different operators: + - * / %");

Console.WriteLine("Write a number:");
int number1 = 0;
while (true)
{
    try
    {
        string? userInput1 = Console.ReadLine();
        number1 = Convert.ToInt32(userInput1);
        break;
    }
    catch
    {
        Console.WriteLine("That wasn't a number. Try again please.");
    }
}

Console.WriteLine("Write a another number:");
string? userInput2 = Console.ReadLine();
int number2 = int.Parse(userInput2);

int remainder = number1 % number2;
int wholePart = number1 / number2;

Console.WriteLine($"{number1} % {number2} = {remainder}");
Console.WriteLine($"{number1} / {number2} = {wholePart}");

int orderOfOperations = ( remainder + wholePart ) * 2;
Console.WriteLine($"Result: {orderOfOperations}");

wholePart += 5; //same as writing wholePart = wholePart + 5

wholePart++;
wholePart = wholePart + 1;
wholePart += 1;

wholePart--;
wholePart = wholePart - 1;
wholePart -= 1;

