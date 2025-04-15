int n = int.Parse(Console.ReadLine());

string[] list = Console.ReadLine().Split(" ");

int result = 0;

for (int i = 0; i < n; i++)
{
    int num = int.Parse(list[i]);

    List<int> intList = new List<int>();

    for (int j = 1; j <= num; j++)
    {
        if (num % j == 0) {
            intList.Add(j);
        }
    }

    if (intList.Count == 2) {
        result++;
    }

}

Console.WriteLine(result);


