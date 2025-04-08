
StreamReader sr = new(Console.OpenStandardInput());
StreamWriter sw = new(Console.OpenStandardOutput());

try
{
    // int N = int.Parse(sr.ReadLine() ?? "0");
    // var input = sr.ReadLine() ?? "0";
    // List<int> list = input.Split().Select(item => int.Parse(item)).ToList();

    // var sortedList = list.OrderBy(x=>x).ToList().Select((item, idx) => new {index = idx, value = item}).ToList();

    // list.ForEach( item => {
    //         sw.Write(sortedList.Find(x => x.value == item).index + " ");
    //     }
    // );
    // 위 생각없이 만든 로직은 시간복잡도가 O(N^2)
    // 시간초과 오답 나옴


    int N = int.Parse(sr.ReadLine() ?? "0");
    var input = sr.ReadLine() ?? "0";
    List<int> list = input.Split().Select(item => int.Parse(item)).ToList();
    Dictionary<int, int> dic = new Dictionary<int, int>();
    var idx = 0;

    list.OrderBy(x => x).ToList().ForEach(item => {
        if (dic.TryAdd(item, idx))
            idx++;
    });

    list.ForEach(item => {
        sw.Write(dic[item] + " ");
    });





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
