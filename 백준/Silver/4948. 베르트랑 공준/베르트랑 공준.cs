

StreamReader sr = new(Console.OpenStandardInput());
StreamWriter sw = new(Console.OpenStandardOutput());

try
{

    // 베르트랑 공준
    // 입력값 n 에 대하여 n < 소수의 갯수 <= 2n
    // 1 <= n <= 123456

    while(true) {


        int n = int.Parse(sr.ReadLine() ?? "");
        
        if (n == 0)
        break;

        bool[] isNotPrime = new bool[2*n+1];

        isNotPrime[1] = true; // 소수가 아님

        for (int i = 2; i*i <= 2*n; i++) // 2부터 N의제곱근까지 (합성수는 N의제곱근이하까지는 무조건 약수가 존재하기때문에)
        {
            for (int j = i*i; j <= 2*n; j += i) // 약수의 배수들은 전부 소수가 아님
            {
                isNotPrime[j] = true;
            }
        }
        
        int cnt = 0;
        for (int i = n+1; i <= 2*n; i++)
        {
            if (!isNotPrime[i])
            cnt++;
        }

        sw.WriteLine(cnt);

    }

    

}
catch (Exception ex)
{
    sw.WriteLine(ex.Message);
}
finally
{
    sr.Close();
    sw.Close();
}