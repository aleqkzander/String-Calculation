using String_Calculation;

bool isActive = true;

while (isActive)
{
    Console.Write("Provide an expression: ");
    string input = Console.ReadLine()!;
    int solution = ExpressionReader.Answer(input);
    Console.WriteLine("The solution is: " + solution);
}