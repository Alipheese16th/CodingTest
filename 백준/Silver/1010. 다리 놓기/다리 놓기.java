import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.InputStreamReader;
import java.io.OutputStreamWriter;

public class Main {
    
    public static void main(String[] args) throws Exception {
        
        
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        BufferedWriter bw = new BufferedWriter(new OutputStreamWriter(System.out));
        
        int N = Integer.parseInt(br.readLine());
        
        // factorial(m) / (factorial(m-n) * factorial(n));
        // 그냥 팩토리얼로 풀면 입력수에 따라 너무 수가 커짐 
        // 저걸 동적 계획법으로 풀어쓰면
        
        for (int i = 0; i < N; i++) {
            
            String[] input = br.readLine().split(" ");
            int n = Integer.parseInt(input[0]); // 왼쪽
            int m = Integer.parseInt(input[1]); // 오른쪽
            
            bw.write(String.valueOf(combination(m, n))); // mCn 계산
            bw.newLine();
            
        }
        
        bw.flush();
        bw.close();
        br.close();
    }
    
    public static long combination(int m, int n) { // 4 중에 3개 고른다면
        
        long result = 1;
        
        for (int i = 1; i <= n; i++) {
            
            result = result * (m - i + 1) / i;
            
        }
        
        return result;
    }

}
