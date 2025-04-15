
List<int> intList = new();

for (int i = 0; i < 5; i++)
{
    intList.Add(int.Parse(Console.ReadLine()));
}

intList.Sort((a, b) => a.CompareTo(b));

Console.WriteLine(intList.Average());
Console.WriteLine(intList[2]);


