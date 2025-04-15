int N = int.Parse(Console.ReadLine());

int i = 0;
while (true) {
    i++;

    if (i.ToString().Contains("666")) {
        N--;
    } 

    if (N == 0) {
        Console.WriteLine(i);
        break;
    }

}


