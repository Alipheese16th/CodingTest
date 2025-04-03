using System;
using System.IO;
using System.Collections.Generic;

StreamReader sr = new StreamReader(Console.OpenStandardInput());
StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

try
{
    int n = int.Parse(sr.ReadLine());

    List<int> intList = new List<int>();

    for (int i = 0; i < n; i++)
    {
        intList.Add(int.Parse(sr.ReadLine()));
    }

    MergeSort(intList, 0, intList.Count - 1);

    foreach (int x in intList)
    {
        sw.WriteLine(x);
    }
}
catch (Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}
finally
{
    sr.Close();
    sw.Close();
}
    

void MergeSort(List<int> arr, int left, int right)
{
    if (left < right)
    {
        int mid = (left + right) / 2;
        MergeSort(arr, left, mid);
        MergeSort(arr, mid + 1, right);
        Merge(arr, left, mid, right);
    }
}

void Merge(List<int> arr, int left, int mid, int right)
{
    int[] temp = new int[right - left + 1];
    int i = left;
    int j = mid + 1;
    int k = 0;

    while (i <= mid && j <= right)
    {
        if (arr[i] <= arr[j])
            temp[k++] = arr[i++];
        else
            temp[k++] = arr[j++];
    }

    while (i <= mid)
        temp[k++] = arr[i++];

    while (j <= right)
        temp[k++] = arr[j++];

    for (i = 0; i < k; i++)
        arr[left + i] = temp[i];
}
