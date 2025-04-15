
string[] input = Console.ReadLine().Split();
int a1 = int.Parse(input[0]);
int a0 = int.Parse(input[1]);
int c = int.Parse(Console.ReadLine());
int n0 = int.Parse(Console.ReadLine());



if (a1 * n0 + a0 <= c * n0 && c >= a1) {
    Console.WriteLine(1);
} else {
    Console.WriteLine(0);
}

