import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class Main {
	
	public static void main(String[] args) throws IOException {
		
		BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));
		String input;
		
		while ((input = reader.readLine()) != null) {
			
			int cnt = Integer.parseInt(input);
			System.out.println(cantor(cnt));
			
		}
		
	}
	
	public static String cantor(int n) {
	    if (n == 0) return "-";
	    
    	String prev = cantor(n - 1);
    	return prev + repeatSpace((int)Math.pow(3, n - 1)) + prev;
	    
	}
	
	public static String repeatSpace(int count) {
	    StringBuilder sb = new StringBuilder();
	    for (int i = 0; i < count; i++) {
	        sb.append(" ");
	    }
	    return sb.toString();
	}

	
}
