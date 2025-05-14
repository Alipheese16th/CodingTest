import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.IOException;
import java.io.InputStreamReader;
import java.io.OutputStreamWriter;
import java.util.ArrayDeque;
import java.util.Arrays;
import java.util.Deque;

public class Main {
    public static void main(String[] args) throws IOException {
        
        
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        BufferedWriter bw = new BufferedWriter(new OutputStreamWriter(System.out));

        int N = Integer.parseInt(br.readLine());
        
        int[] A = Arrays.stream(br.readLine().split(" ")).mapToInt(Integer::parseInt).toArray();

        Deque<Integer> queue = new ArrayDeque<>();
        
        int[] B = Arrays.stream(br.readLine().split(" ")).mapToInt(Integer::parseInt).toArray();

        for (int i = 0; i < N; i++) {
            int value = B[i];
            if (A[i] == 0) {
                queue.addLast(value);
            }
        }

        int M = Integer.parseInt(br.readLine());
        
        int[] C = Arrays.stream(br.readLine().split(" ")).mapToInt(Integer::parseInt).toArray();

        for (int i = 0; i < M; i++) {
            int input = C[i];
            
            if (queue.size() > 0) {
                int output = queue.pollLast();
                bw.write(output + " ");
                queue.addFirst(input);
                
            } else {
                bw.write(input + " ");
            }

        }

        bw.flush();
        bw.close();
        br.close();
        
    }
}
