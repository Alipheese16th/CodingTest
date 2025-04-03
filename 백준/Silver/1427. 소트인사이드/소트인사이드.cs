StreamReader sr = new(Console.OpenStandardInput());
StreamWriter sw = new(Console.OpenStandardOutput());

try
{
  
    string result = new string(sr.ReadLine().OrderByDescending(x => x).ToArray());

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




    

