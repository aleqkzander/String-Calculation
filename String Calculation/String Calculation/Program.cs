using String_Calculation;

bool isActive = true;

while (isActive)
{
    Console.Write("\nProvide an expression: ");
    string input = Console.ReadLine()!;
    ExpressionReader.Answer(input);
}