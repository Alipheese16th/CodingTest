
// 계수정렬
// 해당하는 항목의 값을 인덱스로 배열에 카운트

StreamReader sr = new(Console.OpenStandardInput());
StreamWriter sw = new(Console.OpenStandardOutput());

try
{
    int n = int.Parse(sr.ReadLine());

    int[] list = new int[10001];

    for (int i = 0; i < n; i++)
    {
        int num = int.Parse(sr.ReadLine());
        list[num]++;
    }

    for (int i = 0; i < list.Length; i++)
    {
        if (list[i] !=0) {
            for (int j = 0; j < list[i]; j++)
            {
                sw.WriteLine(i);
            }
        }
    }


}
catch (Exception ex)
{
}
finally
{
    sr.Close();
    sw.Close();
}




    

