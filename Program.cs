Random rnd = new Random();
int randomNumber = rnd.Next(1,101);

Console.Write("Choose a number between 1-100: ");
int userInput = int.Parse(Console.ReadLine());

int difference = randomNumber - userInput;

if (userInput == randomNumber) 
{
    Console.WriteLine("Good job, you're correct!");
}
else if (userInput > randomNumber)
{
    Console.WriteLine("Wayyyy too much, try again!");
}
else if (userInput < randomNumber)
{
    Console.WriteLine("Your guess is too low, please try again!");
    Console.WriteLine($"You we're off by: {difference}");
}
else 
{
    Console.WriteLine("You're incorrect, try again!");
}