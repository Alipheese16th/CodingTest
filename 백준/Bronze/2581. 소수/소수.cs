
int m = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());


List<int> sosuList = new List<int>();

for (int i = m; i <= n; i++)
{
    List<int> intList = new List<int>();

    for (int j = 1; j <= i; j++)
    {
        if (i % j == 0) {
            intList.Add(j);
        }
    }

    if (intList.Count == 2) {
        sosuList.Add(i);
    }

}

if (sosuList.Count < 1) {
    Console.WriteLine(-1);
} else {
    Console.WriteLine(sosuList.Sum());
    Console.WriteLine(sosuList.Min());
}
