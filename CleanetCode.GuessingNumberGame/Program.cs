Console.WriteLine("Enter your nickname");
string? userName = Console.ReadLine();
Console.WriteLine($"Please, {userName}, guess my number (0 to 1000)");

//creation of random generating value
Random randomValueToGuess = new Random();
int secretNumber = randomValueToGuess.Next(0,1000);

bool isWin = false;
int userNumber = -1;
bool isIntNumber;

int attemptCount = 0;
while (!isWin) //running till expression in the brackets wouldn't become true
{
    do
    {
        Console.WriteLine($"Please, {userName}, make a guess!");
        string? userInput = Console.ReadLine();
        isIntNumber = int.TryParse(userInput, out userNumber);

        attemptCount++;

        if (!isIntNumber)
        {
            Console.WriteLine($"Your input value {userInput} is incorrect");
        }
    } while (!isIntNumber);

    if (userNumber > secretNumber)
    {
        Console.WriteLine($"Your number ({userNumber}) is larger than assumed");
    }
    else if (userNumber < secretNumber)
    {
        Console.WriteLine($"Your number ({userNumber}) is less than assumed");
    }
    else
    {
        Console.WriteLine("You have won!" +
            $" Thank you, {userName}, your number of attempts is {attemptCount}");
        break;
    }
}