
StreamReader sr = new(Console.OpenStandardInput());
StreamWriter sw = new(Console.OpenStandardOutput());

try
{
    List<int> input = (sr.ReadLine() ?? "").Split().Select(x => int.Parse(x)).ToList();
    int N = input[0];
    int M = input[1];

    HashSet<string> nList = new HashSet<string>();
    List<string> mList = new List<string>();

    for (int i = 0; i < N; i++)
    {
        nList.Add(sr.ReadLine() ?? "");
    }

    for (int i = 0; i < M; i++)
    {
        string temp = sr.ReadLine() ?? "";

        if (nList.Contains(temp)) {
            mList.Add(temp);
        }

    }

    sw.WriteLine(mList.Count);
    mList.OrderBy(x=>x).ToList().ForEach(sw.WriteLine);


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


