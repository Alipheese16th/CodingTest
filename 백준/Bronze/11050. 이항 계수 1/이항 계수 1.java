import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.InputStreamReader;
import java.io.OutputStreamWriter;
import java.util.Arrays;

public class Main {
    
    public static void main(String[] args) throws Exception {
        
        
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        BufferedWriter bw = new BufferedWriter(new OutputStreamWriter(System.out));
        
        int[] list = Arrays.stream(br.readLine().split(" ")).mapToInt(Integer::parseInt).toArray();
        
        bw.write(String.valueOf(calc(list[0], list[1])));
        
        bw.flush();
        bw.close();
        br.close();
    }
    
    public static int calc(int n, int k) {
        
        return factorial(n) / (factorial(n-k) * factorial(k));
    }
    
    public static int factorial(int n) {
        if (n <= 1) {
            return 1;
        } else {
            return n*factorial(n-1);
        }
    }
}
