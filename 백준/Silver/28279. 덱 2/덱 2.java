import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.IOException;
import java.io.InputStreamReader;
import java.io.OutputStreamWriter;
import java.util.LinkedList;

public class Main {
    
    public static void main(String[] args) throws IOException {
        
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        BufferedWriter bw = new BufferedWriter(new OutputStreamWriter(System.out));
        
        LinkedList<Integer> list = new LinkedList<Integer>();
        
        
        int N = Integer.parseInt(br.readLine());
        
        
        for (int i = 0; i < N; i++) {
            
            String[] input = br.readLine().split(" ");
            
            int command = Integer.parseInt(input[0]);
            
            switch (command) {
                
                case 1:
                list.addFirst(Integer.parseInt(input[1]));
                break;
                
                case 2:
                list.addLast(Integer.parseInt(input[1]));
                break;
                
                case 3:
                if (list.size() > 0) {
                    bw.write(list.removeFirst().toString());
                    bw.newLine();
                } else {
                    bw.write("-1");
                    bw.newLine();
                }
                break;
                
                case 4:
                if (list.size() > 0) {
                    bw.write(list.removeLast().toString());
                    bw.newLine();
                } else {
                    bw.write("-1");
                    bw.newLine();
                }
                break;
                
                case 5:
                bw.write(String.valueOf(list.size()));
                bw.newLine();
                break;
                
                case 6:
                String isEmpty = list.size() == 0 ? "1" : "0";
                bw.write(isEmpty);
                bw.newLine();
                break;
                
                case 7:
                if (list.size() > 0) {
                    bw.write(list.getFirst().toString());
                    bw.newLine();
                } else {
                    bw.write("-1");
                    bw.newLine();
                }
                break;
                
                case 8:
                if (list.size() > 0) {
                    bw.write(list.getLast().toString());
                    bw.newLine();
                } else {
                    bw.write("-1");
                    bw.newLine();
                }
                break;
            
            }
            
        }
        
        bw.flush();
        bw.close();
        br.close();
        
        
        
    }
}
