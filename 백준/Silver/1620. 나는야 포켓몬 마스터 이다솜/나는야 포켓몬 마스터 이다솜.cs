
using System.Collections;

StreamReader sr = new(Console.OpenStandardInput());
StreamWriter sw = new(Console.OpenStandardOutput());

try
{
    List<int> firstInput = (sr.ReadLine() ?? "").Split().Select(x=>int.Parse(x)).ToList();
    int N = firstInput[0];
    int M = firstInput[1];
    Dictionary<string, int> list = new Dictionary<string, int>();
    string[] reverseList = new string[N];

    for (int i = 0; i < N; i++)
    {
        string input = sr.ReadLine() ?? "";
        list.Add(input, i);
        reverseList[i] = input;
    }

    for (int i = 0; i < M; i++)
    {
        string stringInput = sr.ReadLine() ?? "";
        if (int.TryParse(stringInput, out int intInput)) {
            // 숫자 입력
            sw.WriteLine(reverseList[intInput - 1]);

        } else {
            // 문자 입력
            sw.WriteLine(list[stringInput] + 1);

        }

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


