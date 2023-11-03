Random rnd = new Random();
int userInput;

string asciiArt = @"
                      _                                         _                                            
                     | |                                       | |                                           
  _ __ __ _ _ __   __| | ___  _ __ ___    _ __  _   _ _ __ ___ | |__   ___ _ __    __ _  __ _ _ __ ___   ___ 
 | '__/ _` | '_ \ / _` |/ _ \| '_ ` _ \  | '_ \| | | | '_ ` _ \| '_ \ / _ \ '__|  / _` |/ _` | '_ ` _ \ / _ \
 | | | (_| | | | | (_| | (_) | | | | | | | | | | |_| | | | | | | |_) |  __/ |    | (_| | (_| | | | | | |  __/
 |_|  \__,_|_| |_|\__,_|\___/|_| |_| |_| |_| |_|\__,_|_| |_| |_|_.__/ \___|_|     \__, |\__,_|_| |_| |_|\___|
                                                                                   __/ |                     
                                                                                  |___/                      
";
Console.WriteLine(asciiArt);

string gameOver = @"
                                                   
                                                   
   __ _  __ _ _ __ ___   ___    _____   _____ _ __ 
  / _` |/ _` | '_ ` _ \ / _ \  / _ \ \ / / _ \ '__|
 | (_| | (_| | | | | | |  __/ | (_) \ V /  __/ |   
  \__, |\__,_|_| |_| |_|\___|  \___/ \_/ \___|_|   
   __/ |                                           
  |___/                                            
";

string winner = @"
                                          
                                          
  _   _  ___  _   _  __      _____  _ __  
 | | | |/ _ \| | | | \ \ /\ / / _ \| '_ \ 
 | |_| | (_) | |_| |  \ V  V / (_) | | | |
  \__, |\___/ \__,_|   \_/\_/ \___/|_| |_|
   __/ |                                  
  |___/                                   
";

Console.Write("Choose a difficulty (Very easy|Easy|Medium|Hard|Very hard): ");
string? userDifficulty = Console.ReadLine();

if (string.Equals(userDifficulty, "very easy", StringComparison.OrdinalIgnoreCase))
{
    int randomNumber = rnd.Next(1, 26);

    while (true)
    {
        Console.Write("Choose a number between 1-25: ");
        string? userInputString = Console.ReadLine();
        bool success = int.TryParse(userInputString, out int parsedInput);

    if (parsedInput >= 1 && parsedInput <= 25)
    {
        userInput = parsedInput;
        break;
    }

        Console.WriteLine("Invalid input, please choose a number between 1 and 25.");
    }

    int difference = randomNumber - userInput;
    int positiveDifference = userInput - randomNumber;

    if (userInput == randomNumber) 
    {
        Console.WriteLine(winner);
    }
    else if (userInput > randomNumber)
    {   
        Console.WriteLine(gameOver);
        Console.WriteLine($"You were off by: {positiveDifference}");
    }   
    else if (userInput < randomNumber)
    {
        Console.WriteLine(gameOver);
        Console.WriteLine($"You were off by: {difference}");
    }
    else 
    {
        Console.WriteLine("You're incorrect, try again!");
    }
} else if (string.Equals(userDifficulty, "easy", StringComparison.OrdinalIgnoreCase))
{
    int randomNumber = rnd.Next(1, 101);

    while (true)
    {
        Console.Write("Choose a number between 1-100: ");
        string? userInputString = Console.ReadLine();
        bool success = int.TryParse(userInputString, out int parsedInput);

    if (parsedInput >= 1 && parsedInput <= 100)
    {
        userInput = parsedInput;
        break;
    }

        Console.WriteLine("Invalid input, please choose a number between 1 and 100.");
    }

    int difference = randomNumber - userInput;
    int positiveDifference = userInput - randomNumber;

    if (userInput == randomNumber) 
    {
        Console.WriteLine(winner);
    }
    else if (userInput > randomNumber)
    {   
        Console.WriteLine(gameOver);
        Console.WriteLine($"You were off by: {positiveDifference}");
    }   
    else if (userInput < randomNumber)
    {
        Console.WriteLine(gameOver);
        Console.WriteLine($"You were off by: {difference}");
    }
    else 
    {
        Console.WriteLine("You're incorrect, try again!");
    }
} else if (string.Equals(userDifficulty, "medium", StringComparison.OrdinalIgnoreCase))
{
    int randomNumber = rnd.Next(1, 501);

    while (true)
    {
        Console.Write("Choose a number between 1-500: ");
        string? userInputString = Console.ReadLine();
        bool success = int.TryParse(userInputString, out int parsedInput);

    if (parsedInput >= 1 && parsedInput <= 500)
    {
        userInput = parsedInput;
        break;
    }

        Console.WriteLine("Invalid input, please choose a number between 1 and 500.");
    }

    int difference = randomNumber - userInput;
    int positiveDifference = userInput - randomNumber;

    if (userInput == randomNumber) 
    {
        Console.WriteLine(winner);
    }
    else if (userInput > randomNumber)
    {   
        Console.WriteLine(gameOver);
        Console.WriteLine($"You were off by: {positiveDifference}");
    }   
    else if (userInput < randomNumber)
    {
        Console.WriteLine(gameOver);
        Console.WriteLine($"You were off by: {difference}");
    }
    else 
    {
        Console.WriteLine("You're incorrect, try again!");
    }
} else if (string.Equals(userDifficulty, "hard", StringComparison.OrdinalIgnoreCase))
{
    int randomNumber = rnd.Next(1, 1001);

    while (true)
    {
        Console.Write("Choose a number between 1-1000: ");
        string? userInputString = Console.ReadLine();
        bool success = int.TryParse(userInputString, out int parsedInput);

    if (parsedInput >= 1 && parsedInput <= 1000)
    {
        userInput = parsedInput;
        break;
    }

        Console.WriteLine("Invalid input, please choose a number between 1 and 1000.");
    }

    int difference = randomNumber - userInput;
    int positiveDifference = userInput - randomNumber;

    if (userInput == randomNumber) 
    {
        Console.WriteLine(winner);
    }
    else if (userInput > randomNumber)
    {   
        Console.WriteLine(gameOver);
        Console.WriteLine($"You were off by: {positiveDifference}");
    }   
    else if (userInput < randomNumber)
    {
        Console.WriteLine(gameOver);
        Console.WriteLine($"You were off by: {difference}");
    }
    else 
    {
        Console.WriteLine("You're incorrect, try again!");
    }
} else if (string.Equals(userDifficulty, "very hard", StringComparison.OrdinalIgnoreCase))
{
    int randomNumber = rnd.Next(1, 5001);

    while (true)
    {
        Console.Write("Choose a number between 1-5000: ");
        string? userInputString = Console.ReadLine();
        bool success = int.TryParse(userInputString, out int parsedInput);

    if (parsedInput >= 1 && parsedInput <= 5000)
    {
        userInput = parsedInput;
        break;
    }

        Console.WriteLine("Invalid input, please choose a number between 1 and 5000.");
    }

    int difference = randomNumber - userInput;
    int positiveDifference = userInput - randomNumber;

    if (userInput == randomNumber) 
    {
        Console.WriteLine(winner);
    }
    else if (userInput > randomNumber)
    {   
        Console.WriteLine(gameOver);
        Console.WriteLine($"You were off by: {positiveDifference}");
    }   
    else if (userInput < randomNumber)
    {
        Console.WriteLine(gameOver);
        Console.WriteLine($"You were off by: {difference}");
    }
    else 
    {
        Console.WriteLine("You're incorrect, try again!");
    }
} else 
{
        Console.WriteLine("Please choose either easy, medium or hard...");
}