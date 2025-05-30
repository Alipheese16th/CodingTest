
StreamReader sr = new(Console.OpenStandardInput());
StreamWriter sw = new(Console.OpenStandardOutput());


int T = int.Parse(sr.ReadLine() ?? "");


int count;
int result;

for (int i = 0; i < T; i++)
{

    string input = sr.ReadLine() ?? "";

    count = 0;

    result = isPalindrome(input, ref count);

    sw.WriteLine(result + " " + count);


}


int recursion (string s, int l, int r, ref int count) {
    count++;
    if(l >= r) return 1;
    else if(s[l] != s[r]) return 0;
     else return recursion(s, l+1, r-1, ref count);
}
int isPalindrome(String s, ref int count){
    return recursion(s, 0, s.Length-1, ref count);
}




sr.Close();
sw.Close();
