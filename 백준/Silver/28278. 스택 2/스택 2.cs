

StreamReader sr = new(Console.OpenStandardInput());
StreamWriter sw = new(Console.OpenStandardOutput());

try
{

    int N = int.Parse(sr.ReadLine() ?? "");
    Stack<int> stack = new Stack<int>();

    for (int i = 0; i < N; i++)
    {

        int[] input = (sr.ReadLine() ?? "").Split().Select(int.Parse).ToArray();


        switch (input[0])
        {
            case 1:
            int X = input[1];
            stack.Push(X);
            break;

            case 2:
            int pop = stack.Count == 0 ? -1 : stack.Pop();
            sw.WriteLine(pop);
            break;
            
            case 3:
            sw.WriteLine(stack.Count);
            break;

            case 4:
            int count = stack.Count == 0 ? 1 : 0;
            sw.WriteLine(count);
            break;
            
            case 5:
            int peek = stack.Count == 0 ? -1 : stack.Peek();
            sw.WriteLine(peek);
            break;
        }
        
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