




string[] input = Console.ReadLine().Split();

int a = int.Parse(input[0]);
int b = int.Parse(input[1]);

int cnt = 0;

for (int i = 1; i <= a; i++)
{
    if (a%i == 0)
    {
        ++cnt;
    }
    if (cnt == b)
    {
        Console.WriteLine(i);
        break;
    }

    if (i == a && cnt < b)
    {
        Console.WriteLine(0);
    }

}






