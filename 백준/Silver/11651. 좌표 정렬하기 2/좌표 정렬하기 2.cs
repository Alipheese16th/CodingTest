StreamReader sr = new(Console.OpenStandardInput());
StreamWriter sw = new(Console.OpenStandardOutput());

try
{

    int N = int.Parse(sr.ReadLine());

    List<(int y, int x)> list = new();

    for (int i = 0; i < N; i++)
    {
        string[] input = sr.ReadLine().Split();
        list.Add((int.Parse(input[1]), int.Parse(input[0])));
        
    }

    list.Sort();
    
    list.ForEach(item=>sw.WriteLine(item.x + " " + item.y));




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
