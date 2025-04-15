
int n = int.Parse(Console.ReadLine());

List<int> list = new List<int>();

if (n > 1) {

    int result = insubunhae(n, list);

    while (result != -1) {

        result = insubunhae(result, list);

    }

    foreach (var item in list)
    {
        Console.WriteLine(item);
    }



}


int insubunhae(int insu, List<int> list) {

    for (int i = 2; i <= insu; i++)
    {
        if (insu % i == 0) {
            list.Add(i);
            return insu / i;
        }
    }

    return -1;
}




