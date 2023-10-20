Random rnd = new Random();
int randomNumber = rnd.Next(1,101);
Console.WriteLine(randomNumber);

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

int userInput = 0;

while (true)
{
    Console.Write("Choose a number between 1-100: ");
    userInput = int.Parse(Console.ReadLine());

    if (userInput >= 1 && userInput <= 100)
    {
        break;
    }

    Console.WriteLine("Invalid input, please choose a number between 1 and 100.");
}

int difference = randomNumber - userInput;
int positiveDifference = userInput - randomNumber;
try
{
    if (userInput == randomNumber) 
    {
        Console.WriteLine(winner);
    }
    else if (userInput > randomNumber)
    {   
        Console.WriteLine(gameOver);
        Console.WriteLine($"You we're off by: {positiveDifference}");
    }
    else if (userInput < randomNumber)
    {
        Console.WriteLine(gameOver);
        Console.WriteLine($"You we're off by: {difference}");
    }
    else 
    {
        Console.WriteLine("You're incorrect, try again!");
    }
} catch (Exception e)
{
    Console.WriteLine(e.Message);
}