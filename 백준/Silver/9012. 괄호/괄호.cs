

StreamReader sr = new(Console.OpenStandardInput());
StreamWriter sw = new(Console.OpenStandardOutput());

try
{

    int T = int.Parse(sr.ReadLine() ?? "");

    for (int i = 0; i < T; i++)
    {
        Stack<int> stack = new Stack<int>();

        string input = sr.ReadLine() ?? "";
        foreach (var item in input)
        {
            if ('('.Equals(item)) {
                stack.Push(1);
            } else if (')'.Equals(item) && stack.Count == 0) {
                stack.Push(1);
                break;
            } else {
                stack.Pop();
            }

        }

        if (stack.Count == 0)
            sw.WriteLine("YES");
        else
         sw.WriteLine("NO");

        
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