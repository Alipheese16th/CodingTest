import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.InputStreamReader;
import java.io.OutputStreamWriter;

public class Main {
    
    public static void main(String[] args) throws Exception {
        
        
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        BufferedWriter bw = new BufferedWriter(new OutputStreamWriter(System.out));
        
        int N = Integer.parseInt(br.readLine());
        
        bw.write(String.valueOf(factorial(N)));
        
        
        bw.flush();
        bw.close();
        br.close();
    }
    
    public static int factorial(int n) {
        
        if (n <= 1) {
            return 1;
        } else {
            return n*factorial(n-1);
        }
    }
}
