int N = int.Parse(Console.ReadLine());

int fiveIndex = N / 5;
bool isFound = false;

for (int i = fiveIndex; i >= 0; i--) {
    int fiveKg = i * 5;
    int threeKg = (N - fiveKg) / 3;
    int result = (N - fiveKg) % 3;
    
    if (result == 0) {
        Console.WriteLine(i + threeKg);
        isFound = true;
        break;
    }
}

if (!isFound) {
    Console.WriteLine(-1);
}





