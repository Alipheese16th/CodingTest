int n = int.Parse(Console.ReadLine());

List<int> xList = new List<int>();
List<int> yList = new List<int>();

for (int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine().Split();
    xList.Add(int.Parse(input[0]));
    yList.Add(int.Parse(input[1]));
}

int maxX = xList.Max();
int minX = xList.Min();

int maxY = yList.Max();
int minY = yList.Min();

Console.WriteLine((maxX - minX)*(maxY - minY));
