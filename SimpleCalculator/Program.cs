Console.WriteLine("Hello!");
Console.WriteLine("Input the first number:");
int firstNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Input the second number:");
int secondNumber = int.Parse(Console.ReadLine());
Console.WriteLine("What do you want to do with those numbers?");
Console.WriteLine("[A]dd");
Console.WriteLine("[S]ubtract");
Console.WriteLine("[M]ultiply");
string operation = Console.ReadLine().ToUpper();
if (operation == "A")
{
    Console.WriteLine(Add(firstNumber, secondNumber));
}
else if (operation == "S")
{
    Console.WriteLine(Subtract(firstNumber, secondNumber));
}
else if (operation == "M")
{
    Console.WriteLine(Multiply(firstNumber, secondNumber));
}
else
{
    Console.WriteLine("Invalid option.");
}
Console.ReadKey();
string Add(int firstNumber, int secondNumber) 
{
    var result = $"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}";
    return result;
}

string Subtract(int firstNumber, int secondNumber)
{
    var result = $"{firstNumber} - {secondNumber} = {firstNumber - secondNumber}";
    return result;
}

string Multiply(int firstNumber, int secondNumber)
{
    var result = $"{firstNumber} * {secondNumber} = {firstNumber * secondNumber}";
    return result;
}