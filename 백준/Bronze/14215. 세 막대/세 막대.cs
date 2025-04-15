string[] input = Console.ReadLine().Split(" ");
int a = int.Parse(input[0]);
int b = int.Parse(input[1]);
int c = int.Parse(input[2]);

List<int> list = new List<int> { a, b, c };

list.Sort();

if (list[2] >= list[1] + list[0]) {
    list[2] = list[1] + list[0] - 1;
}

Console.WriteLine(list.Sum());
