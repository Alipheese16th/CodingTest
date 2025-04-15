while (true) {
    string[] input = Console.ReadLine().Split(" ");
    int n1 = int.Parse(input[0]);
    int n2 = int.Parse(input[1]);
    int n3 = int.Parse(input[2]);

    List<int> nList = new List<int> { n1, n2, n3 };

    if (nList.Sum() == 0)
        break;

    nList.Sort();  // 작은 순서대로 정렬

    // 삼각형 조건 먼저 체크
    if (nList[0] + nList[1] <= nList[2])
    {
        Console.WriteLine("Invalid");
    }
    else if (n1 == n2 && n2 == n3)
    {
        Console.WriteLine("Equilateral");
    }
    else if (n1 == n2 || n2 == n3 || n1 == n3)
    {
        Console.WriteLine("Isosceles");
    }
    else
    {
        Console.WriteLine("Scalene");
    }



    
}
