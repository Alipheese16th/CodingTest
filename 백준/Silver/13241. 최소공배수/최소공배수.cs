

StreamReader sr = new(Console.OpenStandardInput());
StreamWriter sw = new(Console.OpenStandardOutput());

try
{

    long[] input = (sr.ReadLine() ?? "").Split().Select(x => long.Parse(x)).ToArray();
    sw.WriteLine(input[0] * input[1] / getGCD(input[0], input[1]));

    static long getGCD(long x, long y) {
        return x%y == 0 ? y : getGCD(y, x%y);
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


