

StreamReader sr = new(Console.OpenStandardInput());
StreamWriter sw = new(Console.OpenStandardOutput());

try
{
    int T = int.Parse(sr.ReadLine() ?? "");

    for (int i = 0; i < T; i++)
    {
        int[] input = (sr.ReadLine() ?? "").Split().Select(x => int.Parse(x)).ToArray();

        sw.WriteLine(input[0] * input[1] / getGCD(input[0], input[1]));

    }

    int getGCD(int num1, int num2) {

        while (num1 != 0 && num2 != 0) {

            if (num1 > num2)
            num1 %= num2;
            else
            num2 %= num1;

        }

        return num1 + num2;

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


