
StreamReader sr = new(Console.OpenStandardInput());
StreamWriter sw = new(Console.OpenStandardOutput());

try
{
    int N = int.Parse(sr.ReadLine() ?? "");
    List<int> nList = (sr.ReadLine() ?? "").Split().Select(x => int.Parse(x)).ToList();
    int M = int.Parse(sr.ReadLine() ?? "");
    List<int> mList = (sr.ReadLine() ?? "").Split().Select(x => int.Parse(x)).ToList();

    var map = nList.GroupBy(x=>x).ToDictionary(group => group.Key, group => group.Count());

    var result = mList.Select(x => 
        map.TryGetValue(x, out int value) ? value : 0
    );

    sw.WriteLine(string.Join(" ", result));

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


