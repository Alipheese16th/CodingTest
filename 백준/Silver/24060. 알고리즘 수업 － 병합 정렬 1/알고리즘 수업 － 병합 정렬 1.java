import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.Arrays;

public class Main {
	
	static int[] tmp;
	static int[] array;
	static int length;
	static int count;
	static int cnt;
	
	public static void main(String[] args) throws IOException {
		BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));
		
		int[] firstInput = Arrays.stream(reader.readLine().split(" ")).mapToInt(Integer::parseInt).toArray();
		array = Arrays.stream(reader.readLine().split(" ")).mapToInt(Integer::parseInt).toArray();
		length = firstInput[0];
		count = firstInput[1];
		cnt = 0;
		tmp = new int[length];
		
		merge_sort(array, 0, length-1);
		if (cnt < count) {
			System.out.println(-1);
		}
		
	}
	
	public static void merge_sort(int[] A, int low, int high) {
		if (low < high) {
			int mid = (low + high) / 2;
			merge_sort(A, low, mid);
			merge_sort(A, mid + 1, high);
			merge(A, low, mid, high);
		}
	}
	
	public static void merge(int[] A, int low, int mid, int high) {
		int i = low;
		int j = mid + 1;
		int t = 0;
		
		while (i <= mid && j <= high) {
			if (A[i] <= A[j]) {
				tmp[t++] = A[i++];
			} else {
				tmp[t++] = A[j++];
			}
		}
		while (i <= mid) {
			tmp[t++] = A[i++];
		}
		while (j <= high) {
			tmp[t++] = A[j++];
		}
		
		i = low;
		t = 0;
		while (i <= high) {
			cnt++;
			if (count == cnt) {
				System.out.println(tmp[t]);
			}
			A[i++] = tmp[t++];
		}
			
			
	}
}
