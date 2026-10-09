using Statistics.Lib;

Console.WriteLine("Start test");
for(int i = -10 ; i <= 10; i++)
{
    if(Class1.IsEven(i) == true)
    {
        Console.WriteLine($"Number {i} is even");
    }
    else Console.WriteLine($"Number {i} is odd");
}

