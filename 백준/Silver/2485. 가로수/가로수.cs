

StreamReader sr = new(Console.OpenStandardInput());
StreamWriter sw = new(Console.OpenStandardOutput());

try
{

    int N = int.Parse(sr.ReadLine() ?? "");
    List<int> list = new List<int>();

    int min = 0;
    for (int i = 0; i < N; i++)
    {
        int input = int.Parse(sr.ReadLine() ?? "");

        if (i != 0) 
        list.Add(input-min);

        min = input;
    }

    int gcp = 0;
    foreach (var item in list)
    {
        gcp = gcp == 0 ? item : getGCP(gcp, item);
    }
    
    sw.WriteLine(list.Select(x => (x/gcp) -1).Sum());


    int getGCP (int x, int y) {
        return x%y==0?y:getGCP(y,x%y);
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