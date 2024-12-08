using System;

class GamingPreferenceGame
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Gaming Quiz!");
        Console.Write("What is your nickname? ");
        string playerName = Console.ReadLine();

        Console.WriteLine($"\nHello, {playerName}! Let’s explore your gaming preferences.\n");

        // Question 1
        Console.WriteLine("Q1: Which type of gaming platform would you prefer?");
        Console.WriteLine("A) Console");
        Console.WriteLine("B) PC");
        Console.Write("Your choice (A/B): ");
        string choice1 = Console.ReadLine().ToUpper();

        // Question 2 - Branch based on Q1
        if (choice1 == "A")
        {
            Console.WriteLine("\nQ2: What type of console games do you prefer?");
            Console.WriteLine("A) Action-adventure games");
            Console.WriteLine("B) Sports or racing games");
            Console.Write("Your choice (A/B): ");
        }
        else if (choice1 == "B")
        {
            Console.WriteLine("\nQ2: What type of PC games do you enjoy the most?");
            Console.WriteLine("A) Strategy games");
            Console.WriteLine("B) First-person shooters");
            Console.Write("Your choice (A/B): ");
        }
        else
        {
            Console.WriteLine("Invalid choice. Restart the game.");
            return;
        }
        string choice2 = Console.ReadLine().ToUpper();

        // Question 3 - Common question
        Console.WriteLine("\nQ3: You’re playing a game, and you find an optional quest. What do you do?");
        Console.WriteLine("A) Take the quest immediately for extra rewards");
        Console.WriteLine("B) Skip it to focus on the main story");
        Console.Write("Your choice (A/B): ");
        string choice3 = Console.ReadLine().ToUpper();

        // Final Question - Further branch based on Q2
        if (choice2 == "A")
        {
            Console.WriteLine("\nQ4: You’re about to play multiplayer. What role do you prefer?");
            Console.WriteLine("A) The leader or attacker");
            Console.WriteLine("B) The supporter or strategist");
        }
        else
        {
            Console.WriteLine("\nQ4: You’re starting a new single-player game. Which one is more important?");
            Console.WriteLine("A) Immersive story");
            Console.WriteLine("B) High replay value");
        }
        Console.Write("Your choice (A/B): ");
        string choice4 = Console.ReadLine().ToUpper();

        // Dynamic Outcome
        Console.WriteLine($"\nThanks for playing, {playerName}! Here’s what your choices reveal:");

        if (choice1 == "A" && choice4 == "A")
        {
            Console.WriteLine("You’re a console gamer who loves taking charge and diving into action-packed experiences!");
        }
        else if (choice1 == "B" && choice4 == "B")
        {
            Console.WriteLine("You’re a PC gamer who values depth and replayability in every game you play.");
        }
        else if (choice3 == "A")
        {
            Console.WriteLine("Your eagerness to explore optional content shows your love for uncovering every secret in games!");
        }
        else
        {
            Console.WriteLine("Your focus on the main objectives shows your determination to complete what you start.");
        }

        Console.WriteLine("\nThat’s the end of the game. Thanks for playing, and happy gaming!");
    }
}

  


