

using System.Data;
using System.Net.Sockets;
using System.Security.Authentication.ExtendedProtection;

StreamReader sr = new(Console.OpenStandardInput());
StreamWriter sw = new(Console.OpenStandardOutput());

try
{

    // 분수 두개를 합치고 기약분수로서 출력해야함.
    // 1. 두 분수를 합치려면 분모가 서로 같아야함. 서로 다르다면 걍 곱해
    // 2. 분자를 합치고나서 기약분수가 될때가지 분자와 분모의 최대공약수로 나눠야함

    // 예시
    // 2  3
    // 7  5
    // 분모의 최대공배수는 7과 5의 35
    // 분자의 합은 31 분모는 35가 됐으니까 양측의 최대공약수는 1이다. 그럼 나눌게 없으니까 걍 이대로 답변 제출

    int[] input = (sr.ReadLine() ?? "").Split().Select(x => int.Parse(x)).ToArray();

    int a1 = input[0];
    int b1 = input[1];

    int[] input2 = (sr.ReadLine() ?? "").Split().Select(x => int.Parse(x)).ToArray();

    int a2 = input2[0];
    int b2 = input2[1];

    int resultA;
    int resultB;

    if (b1 != b2) {

        int sumA = a1*b2 + a2*b1;
        int gcd = findGCD(sumA, b1*b2);

        resultA = sumA/gcd;
        resultB = b1*b2/gcd;
        
    } else {

        int sumA = a1 + a2;
        int gcd = findGCD(sumA, b1);

        resultA = sumA/gcd;
        resultB = b1/gcd;

    }

    sw.WriteLine(resultA + " " + resultB);

    int findGCD (int x, int y) {
        return x%y == 0 ? y : findGCD(y, x%y);
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