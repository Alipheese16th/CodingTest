
int n1 = int.Parse(Console.ReadLine());
int n2 = int.Parse(Console.ReadLine());
int n3 = int.Parse(Console.ReadLine());

List<int> nList = new List<int>();
nList.Add(n1);
nList.Add(n2);
nList.Add(n3);

var dupList = nList.GroupBy(x => x).Where(x => x.Count() > 1).ToList();

if (n1 == 60 && n2 == 60 && n3 == 60) {
    Console.WriteLine("Equilateral");
} else if (nList.Sum() == 180 && dupList.Count > 0) {
    Console.WriteLine("Isosceles");
} else if (nList.Sum() == 180 && dupList.Count == 0) {
    Console.WriteLine("Scalene");
} else {
    Console.WriteLine("Error");
}
