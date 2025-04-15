
List<int> xList = new List<int>();
List<int> yList = new List<int>();

for (int i = 0; i < 3; i++)
{
    string[] input = Console.ReadLine().Split();
    xList.Add(int.Parse(input[0]));
    yList.Add(int.Parse(input[1]));
}

// 중복된 값(2개 이상 등장하는 값) 찾기
var duplicatesX = xList.GroupBy(x => x)
                      .Where(g => g.Count() > 1)
                      .Select(g => g.Key)
                      .ToList();

// 중복된 값 모두 제거
var resultX = xList.Where(x => !duplicatesX.Contains(x)).ToList().Max();

// 중복된 값(2개 이상 등장하는 값) 찾기
var duplicatesY = yList.GroupBy(y => y)
                      .Where(g => g.Count() > 1)
                      .Select(g => g.Key)
                      .ToList();

// 중복된 값 모두 제거
var resultY = yList.Where(y => !duplicatesY.Contains(y)).ToList().Max();

Console.WriteLine(resultX + " " + resultY);

