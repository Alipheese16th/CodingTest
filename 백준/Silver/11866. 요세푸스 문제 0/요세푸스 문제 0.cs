
using System.Text;

StreamReader sr = new(Console.OpenStandardInput());
StreamWriter sw = new(Console.OpenStandardOutput());


int[] input = (sr.ReadLine() ?? "").Split().Select(int.Parse).ToArray();

int N = input[0];
int K = input[1];

Queue<int> que = new Queue<int>();
List<int> result = new List<int>();
StringBuilder sb = new StringBuilder();

sb.Append('<');

for (int i = 1; i <= N; i++)
{
    que.Enqueue(i);
}

while(que.Count > 0) {

    for (int i = 0; i < K-1; i++)
    {
        que.Enqueue(que.Dequeue());
    }

    result.Add(que.Dequeue());

}

sb.Append(string.Join(", ", result));
sb.Append('>');

sw.WriteLine(sb);






sr.Close();
sw.Close();
