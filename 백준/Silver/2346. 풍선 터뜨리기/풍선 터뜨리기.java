import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.IOException;
import java.io.InputStreamReader;
import java.io.OutputStreamWriter;
import java.util.ArrayDeque;
import java.util.Deque;

public class Main {
    
    public static void main(String[] args) throws IOException {
        
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        BufferedWriter bw = new BufferedWriter(new OutputStreamWriter(System.out));
        
        int N = Integer.parseInt(br.readLine());
        
        String[] input = br.readLine().split(" ");
        
        Deque<int[]> deq = new ArrayDeque<>(); 
        // 아 LinkedList 로 구현했더니 각 노드의 참조포인터 값 등 메모리 할당량이 커서 자꾸 메모리 초과가 났다. 걍 ArrayDeque 첨부터 썻으면 금방 끝났을것을.....
        

        for (int i = 0; i < N; i++) {
            deq.add(new int[]{i + 1, Integer.parseInt(input[i])});
        }
        
        StringBuilder sb = new StringBuilder();
        
        int[] item = deq.removeFirst();
        sb.append(item[0] + " ");
        int command = item[1];
        
        for (int i = 0; i < N-1; i++) {
            
            if (command > 0) {
                
                for (int j = 0; j < command-1; j++) {
                    deq.addLast(deq.removeFirst());
                }
                item = deq.removeFirst();
                sb.append(item[0] + " ");
                command = item[1];
                
                
            } else if (command < 0) {
                
                for (int j = 0; j > command+1; j--) {
                    deq.addFirst(deq.removeLast());
                }
                item = deq.removeLast();
                sb.append(item[0] + " ");
                command = item[1];
                
            }
            
        }
        
        bw.write(sb.toString());
        
        bw.flush();
        bw.close();
        br.close();
        
        
    }
    

}