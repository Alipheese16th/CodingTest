StreamReader sr = new(Console.OpenStandardInput());
StreamWriter sw = new(Console.OpenStandardOutput());

try
{

    int N = int.Parse(sr.ReadLine());
    List<string> list = new List<string>();

    for (int i = 0; i < N; i++)
    {
        list.Add(sr.ReadLine());
    }

    // 자꾸 왜틀렸나 했더니 나이 숫자로 비교해야됐네 너무 신경안썻다

    list.Select((item, index) =>  new { Name = item.Split()[1], Age = int.Parse(item.Split()[0]), Idx = index})
    .OrderBy(item => item.Age)
    .ThenBy(item => item.Idx)
    .Select(item => item.Age + " " + item.Name)
    .ToList()
    .ForEach(sw.WriteLine);

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
