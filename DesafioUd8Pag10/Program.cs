Random random = new Random();
var normalConsolete = Console.ForegroundColor;
var winConsolete = Console.ForegroundColor;
var loseConsolete = Console.ForegroundColor;

normalConsolete = ConsoleColor.White;
winConsolete = ConsoleColor.Green;
loseConsolete = ConsoleColor.Red;

Console.WriteLine("Would you like to play? (Y/N)", normalConsolete);
if (ShouldPlay()) 
{
    PlayGame();
}

bool ShouldPlay() 
{
    string response = Console.ReadLine();
    return response.ToLower().Equals("y");
}

void PlayGame() 
{
    var play = true;

    while (play) {
        var target = GetTarget();
        var roll = RollDice();

        Console.WriteLine($"Roll a number greater than {target} to win!", Console.ForegroundColor = ConsoleColor.White);
        Console.WriteLine($"You rolled a {roll}", Console.ForegroundColor=ConsoleColor.White);
        //Console.WriteLine(WinOrLose(roll, target));
        //WinOrLose(roll, target) == "You Win" ? Console.WriteLine("You Win", winConsolete) : Console.WriteLine("You Lose", LoseConsolete);
        if (WinOrLose(roll, target)=="You win!"){
            Console.WriteLine("You Win!", Console.ForegroundColor=ConsoleColor.Green);
        }else {
            Console.WriteLine("You Lose!", Console.ForegroundColor = ConsoleColor.Red);
        }
        Console.WriteLine("\nPlay again? (Y/N)", Console.ForegroundColor = ConsoleColor.White);

        play = ShouldPlay();
    }
}

int GetTarget() 
{
    return random.Next(1, 6);
}

int RollDice() 
{
    return random.Next(1, 7);
}

string WinOrLose(int roll, int target) 
{
    if (roll > target) 
    {
        return "You win!";
    }
    return "You lose!";
}