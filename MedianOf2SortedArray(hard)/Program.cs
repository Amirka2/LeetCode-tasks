using System;
using System.Drawing;
using System.Globalization;
using System.Text;
namespace MedianOf2SortedArray_hard_;
class Program
{
//      Given two sorted arrays nums1 and nums2 of size m and n respectively, return the median of the two sorted arrays.
//      The overall run time complexity should be O(log (m+n)).
    static void Main(string[] args)
    {
        int[] arr1 = { 1, 2, 5 };
        int[] arr2 = { 3, 4, 10 };

        Console.WriteLine(FindMedianSortedArrays(arr1, arr2));
    }
    public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        int[] mergedArray = GetMergedArray(nums1, nums2);
        double median;
        int i = 0, j = 0;

        if (mergedArray.Length % 2 == 0)
        {
            j = mergedArray.Length / 2;
            i = j - 1;
            median = ((double)mergedArray[i] + (double)mergedArray[j]) / 2;
        }
        else
        {
            i = mergedArray.Length / 2;
            median = mergedArray[i];
        }

        return median;
    }
    public static int[] GetMergedArray(int[] nums1, int[] nums2)
    {
        int[] mergedArray = new int[nums1.Length + nums2.Length];
        int i = 0, j = 0, index = 0;
        while (i < nums1.Length || j < nums2.Length)
        {
            if (i == nums1.Length)
            {
                mergedArray[index] = nums2[j];
                j++;
                index++;
                continue;
            }
            else if (j == nums2.Length)
            {
                mergedArray[index] = nums1[i];
                i++;
                index++;
                continue;
            }
            if (nums1[i] < nums2[j])
            {
                mergedArray[index] = nums1[i];
                i++;
            }
            else
            {
                mergedArray[index] = nums2[j];
                j++;
            }
            index++;
        }

        return mergedArray;
    }
}

