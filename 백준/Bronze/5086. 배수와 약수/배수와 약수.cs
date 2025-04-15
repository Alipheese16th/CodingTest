




while (true)
{
    string[] input = Console.ReadLine().Split();

    int a = int.Parse(input[0]);
    int b = int.Parse(input[1]);

    if (a == 0 && b == 0)
    {
        break;
    } else if (b % a == 0)
    {
        Console.WriteLine("factor");
    }
    else if (a % b == 0)
    {
        Console.WriteLine("multiple");

    }
    else
    {
        Console.WriteLine("neither");
    }




}



