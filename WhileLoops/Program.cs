Random rnd = new Random();
int cpuRandom;

bool loopActive = true; //bool - true/false
while (loopActive)
{
    cpuRandom = rnd.Next(1, 10);
    Console.WriteLine($"cpu has generated {cpuRandom}");
    Console.WriteLine("Make a guess: Enter a number 1-10");
    int userNumber = Int32.Parse(Console.ReadLine());

    if (userNumber == cpuRandom)
    {
        Console.WriteLine("Good, you won!");
        loopActive = false;
        //break; toimib ka 
    }
    else
    {
        Console.WriteLine("Oops. Try again!");
    }
}

Console.WriteLine("Bye bye");
