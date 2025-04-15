
string[] list = Console.ReadLine().Split(" ");

int x = int.Parse(list[0]);
int y = int.Parse(list[1]);
int w = int.Parse(list[2]);
int h = int.Parse(list[3]);


List<int> intList = new List<int>();

intList.Add(w - x);
intList.Add(h - y);
intList.Add(x);
intList.Add(y);

Console.WriteLine(intList.Min());