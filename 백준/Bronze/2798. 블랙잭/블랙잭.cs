

string[] input = Console.ReadLine().Split();
int n = int.Parse(input[0]);
int m = int.Parse(input[1]);

string[] input2 = Console.ReadLine().Split();

int[] arr = new int[n];

for (int i = 0; i < n; i++) {
    arr[i] = int.Parse(input2[i]);
}

int result = 0;

for (int i = 0; i < arr.Length - 2; i++) {

    for (int j = i + 1; j < arr.Length - 1; j++) {

        for (int k = j + 1; k < arr.Length; k++) {
            var temp = arr[i] + arr[j] + arr[k];
            if (temp <= m && temp > result) {
                result = temp;
            }

        }

    }

}

Console.WriteLine(result);










