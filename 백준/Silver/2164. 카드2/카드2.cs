
StreamReader sr = new(Console.OpenStandardInput());
StreamWriter sw = new(Console.OpenStandardOutput());

if (!int.TryParse(sr.ReadLine() ?? "", out int N)) {
    Console.WriteLine("숫자만 입력하세요오오");
    Environment.Exit(0);
}

Queue<int> que = new Queue<int>();


for (int i = 1; i <= N; i++)
{
    que.Enqueue(i);
}

while(que.Count > 1) {


    que.Dequeue();
    if (que.Count == 1) 
    break;
    
    que.Enqueue(que.Dequeue());


}

sw.WriteLine(que.Dequeue());



sr.Close();
sw.Close();
