
StreamReader sr = new(Console.OpenStandardInput());
StreamWriter sw = new(Console.OpenStandardOutput());


int input = int.Parse(sr.ReadLine() ?? "");

sw.WriteLine(factorial(input));

long factorial(int N) {

    if (N <= 1) {
        return 1;
    } else {
        return N * factorial(N-1);
    }
}


sr.Close();
sw.Close();
