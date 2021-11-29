bool playAgain = true;
Random random = new Random();

while (playAgain)
{
    int computerChoiceIdx = random.Next(1, 4);
    String computerChoice = "";
    switch (computerChoiceIdx)
    {
        case 1:
            computerChoice = "ROCK";
            break;
        case 2:
            computerChoice = "PAPER";
            break;
        case 3:
            computerChoice = "SCISSORS";
            break;
    }
    // Console.WriteLine(computerChoice);

    String playerChoice = "";

    while (playerChoice.ToUpper() != "ROCK" && playerChoice.ToUpper() != "PAPER" && playerChoice.ToUpper() != "SCISSORS")
    {
        Console.Write("What Is Your Choice? (Rock, Paper Or Scissors) - ");
        playerChoice = Console.ReadLine().ToUpper();
    }

    if (computerChoice == playerChoice)
    {
        Console.WriteLine("It Is A Tie!!");
    }
    else if (playerChoice == "ROCK")
    {
        if (computerChoice == "PAPER")
        {
            Console.WriteLine("You Lose!.");
        }
        else if (computerChoice == "SCISSORS")
        {
            Console.WriteLine("You Win!!");
        }
    }
    else if (playerChoice == "PAPER")
    {
        if (computerChoice == "SCISSORS")
        {
            Console.WriteLine("You Lose!.");
        }
        else if (computerChoice == "ROCK")
        {
            Console.WriteLine("You Win!!");
        }
    }
    else if (playerChoice == "SCISSORS")
    {
        if (computerChoice == "ROCK")
        {
            Console.WriteLine("You Lose!.");
        }
        else if (computerChoice == "PAPER")
        {
            Console.WriteLine("You Win!!");
        }
    }

    Console.Write("Wanna Play Again? (Y/N) - ");
    String wannaPlayAgain = Console.ReadLine().ToUpper();
    if (wannaPlayAgain == "N")
    {
        playAgain = false;
        Console.Clear();
        Console.WriteLine("Byeeee!!!");
    }
    else
    {
        Console.Clear();
    }
}
