

int sum = 0;

for(int i = 0; i > 11; i++)
{
    Console.WriteLine($"I = {i}");
    Console.WriteLine($"current total {sum}");
    sum = sum + i;
}

Console.WriteLine($"final sum {sum}");