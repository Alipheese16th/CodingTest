import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.InputStreamReader;
import java.io.OutputStreamWriter;

public class Main {
    
    public static void main(String[] args) throws Exception {
        
        
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        BufferedWriter bw = new BufferedWriter(new OutputStreamWriter(System.out));
        
        
        int N = Integer.parseInt(br.readLine());
        
        int result = 1;
        
        for (int i = 0; i < N; i++) {
            result *= 2;
        }
        
        bw.write(String.valueOf(result));
        
        
        
        bw.flush();
        bw.close();
        br.close();
    }
}