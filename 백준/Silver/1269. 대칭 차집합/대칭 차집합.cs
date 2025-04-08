

StreamReader sr = new(Console.OpenStandardInput());
StreamWriter sw = new(Console.OpenStandardOutput());

try
{
   List<int> count = (sr.ReadLine() ?? "").Split().Select(x=>int.Parse(x)).ToList();
   int ACount = count[0];
   int BCount = count[1];

    List<int> A = (sr.ReadLine() ?? "").Split().Select(x=>int.Parse(x)).ToList();
    List<int> B = (sr.ReadLine() ?? "").Split().Select(x=>int.Parse(x)).ToList();

    var result = A.Except(B).ToList().Concat(B.Except(A).ToList()).Count();

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


