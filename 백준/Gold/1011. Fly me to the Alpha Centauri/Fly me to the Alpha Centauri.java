import java.util.Scanner;

public class Main {
    
    public static void main(String[] args) {
        
        Scanner sc = new Scanner(System.in);
        
        int N = Integer.parseInt(sc.nextLine());
        
        for (int i = 0; i < N; i++) {
            
            String[] input = sc.nextLine().split(" ");
            
            int x = Integer.parseInt(input[0]);
            int y = Integer.parseInt(input[1]);
            int distance = y - x;
            int max = (int)Math.sqrt(distance);
            
            if (max == Math.sqrt(distance)) {
                System.out.println(2 * max - 1);
            } else if (distance <= max * max + max) {
                System.out.println(2 * max);
            } else {
                System.out.println(2 * max + 1);
            }
            
            
        }
        
        sc.close();
        
        
    }
    

}