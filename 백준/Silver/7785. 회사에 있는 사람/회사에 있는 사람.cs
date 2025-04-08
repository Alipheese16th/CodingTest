
using System.Collections;

StreamReader sr = new(Console.OpenStandardInput());
StreamWriter sw = new(Console.OpenStandardOutput());

try
{
    int N = int.Parse(sr.ReadLine() ?? "0");
    HashSet<string> map = new HashSet<string>();

    for (int i = 0; i < N; i++)
    {
        string[] input = (sr.ReadLine() ?? "").Split();

        if ("enter".Equals(input[1])) {
            map.Add(input[0]);

        } else if ("leave".Equals(input[1])) {
            map.Remove(input[0]);

        }


    }

    map.ToList().OrderByDescending(x=>x).ToList().ForEach(sw.WriteLine);


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


