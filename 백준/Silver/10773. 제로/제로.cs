

StreamReader sr = new(Console.OpenStandardInput());
StreamWriter sw = new(Console.OpenStandardOutput());

try
{

    int K = int.Parse(sr.ReadLine() ?? "");
    Stack<int> stack = new Stack<int>();

    for (int i = 0; i < K; i++)
    {

        int input = int.Parse(sr.ReadLine() ?? "");

        if (input == 0) {
            stack.Pop();
        } else {
            stack.Push(input);
        }
        
    }
    sw.WriteLine(stack.Sum());


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