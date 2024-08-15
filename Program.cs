

Console.WriteLine("Average Calculator");

int currentScore = 0;
int sum = 0;
int counter = 0;

do
{
    Console.WriteLine("Enter your student score. Enter -1 to finish!");
    currentScore = Console.
    sum = sum + currentScore;
    counter++;
} while (currentScore < 0);

int average = sum / counter;
Console.WriteLine($"Average is {average}");

Console.ReadKey();