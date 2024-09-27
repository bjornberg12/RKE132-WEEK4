Random rnd  = new Random();

int cpuRandom;
bool loopActive = true;
while (loopActive)
{
    cpuRandom = rnd.Next(1, 4);
    Console.WriteLine("make a guess: ")
       int userNumber = Int32.Parse(Console.ReadLine());

    if (userNumber == cpuRandom)
    {
        Console.WriteLine("you won");
       // loopActive = false; 
       break;
    } else
    {
        Console.WriteLine("try again");
    }

}

Console.WriteLine("have a nice day");