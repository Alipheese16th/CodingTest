
int n = int.Parse(Console.ReadLine());

int result = 0;

for (int i = 0; i < n; i++) {

    int num = i;
    int sum = 0;

    while (true) {
        sum += num % 10;
        num /= 10;
        if (num == 0) break;
    }
    
    if (sum + i == n) {
        result = i;
        Console.WriteLine(result);
        break;
    }
    
}

if (result == 0) Console.WriteLine(0);


