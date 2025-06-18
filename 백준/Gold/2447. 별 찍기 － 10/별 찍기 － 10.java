import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.IOException;
import java.io.InputStreamReader;
import java.io.OutputStreamWriter;

public class Main {
	
	static String[][] list;
	
	public static void main(String[] args) throws IOException {
		
		BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));
		BufferedWriter writer = new BufferedWriter(new OutputStreamWriter(System.out));
		
		int N = Integer.parseInt(reader.readLine());
		
		list = new String[N][N];
		
		for (int i = 0; i < N; i++) {
			for (int j = 0; j < N; j++) {
				list[i][j] = " ";
			}
		}
		
		star(0, 0, N);
		
		for (int i = 0; i < N; i++) {
			for (int j = 0; j < N; j++) {
				writer.write(list[i][j]);
			}
			writer.newLine();
		}
		writer.flush();
		
		
	}
	
	public static void star(int x, int y, int size) { // 0 0 9
		if (size <= 1) {
			list[x][y] = "*";
			
		} else {
			
			int pivot = size / 3; // 3
			
			for (int i = 0; i < 3; i++) { // 0 1 2
				for (int j = 0; j < 3; j++) { // 0 1 2
					
					if (i != 1 || j != 1) {
						
						int one = x + i * pivot; // 0 3 6
						int two = y + j * pivot; // 0 3 6
						
						star(one, two, pivot);
					}
					
					
				}
			}
			
			
		}
		
		
	}
	


	
}
