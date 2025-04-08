
using System.Collections;

StreamReader sr = new(Console.OpenStandardInput());
StreamWriter sw = new(Console.OpenStandardOutput());

try
{
    List<int> input = (sr.ReadLine() ?? "0").Split().Select(x => int.Parse(x)).ToList();
    int N = input[0];
    int M = input[1];

    HashSet<string> map = new HashSet<string>();
    List<string> mList = new List<string>();

    for (int i = 0; i < N; i++)
    {
        map.Add(sr.ReadLine() ?? "");
    }

    for (int i = 0; i < M; i++)
    {
        mList.Add(sr.ReadLine() ?? "");
    }

    // mList 의 집합 중 map의 값이 존재하는지
    // HashSet 은 해시 테이블을 사용하여 탐색 속도가 O(1)

    var result = mList.Where(x=>map.Contains(x)).Count();
    sw.WriteLine(result);


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


