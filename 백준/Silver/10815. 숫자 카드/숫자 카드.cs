
StreamReader sr = new(Console.OpenStandardInput());
StreamWriter sw = new(Console.OpenStandardOutput());

try
{
    int N = int.Parse(sr.ReadLine() ?? "0");
    List<int> nList = (sr.ReadLine() ?? "0").Split().Select(x => int.Parse(x)).OrderBy(x=>x).ToList(); 
    // 이진탐색에 활용할것이라 오름차순으로 정렬
    int M = int.Parse(sr.ReadLine() ?? "0");
    List<int> mList = (sr.ReadLine() ?? "0").Split().Select(x => int.Parse(x)).ToList();

    // 여기서부터 시간복잡도가 중요해진다.
    // 최소 O(logN) 정도의 로직이 되야 정답일듯
    // 이진 탐색으로 간다
    var resultList = mList.Select(m => binarySearch(m)).ToList();
    sw.WriteLine(string.Join(" ", resultList));

    int binarySearch(int value) {

        int left = 0;
        int right = N -1;

        while (left <= right) { 

            int middle = (left + right) / 2;
            int result = nList[middle];
            if (value > result) {
                left = middle + 1;
            } else if (value < result) {
                right = middle - 1;
            } else {
                return 1;
            }

        }

        return 0;

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


