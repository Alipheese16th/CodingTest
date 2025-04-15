int n = int.Parse(Console.ReadLine());

while (n != -1) {

    int sum = 0;
    List<string> list = new List<string>();

    for (int i = 1; i < n; i++)
    {
        if (n % i == 0) {
            sum += i;
            list.Add(i.ToString());
        }
    }

    if (sum == n) {
        Console.WriteLine(n + " = " + string.Join(" + ", list));
    } else {
        Console.WriteLine(n + " is NOT perfect.");
    }

    n = int.Parse(Console.ReadLine());
}


