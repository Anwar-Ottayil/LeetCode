public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        int m = nums1.Length, n = nums2.Length;
        int totalLength = m + n;
        int midIndex1 = (totalLength - 1) / 2;
        int midIndex2 = totalLength / 2;

        int i = 0, j = 0, count = 0;
        int current = 0, prev = 0;

        while (count <= midIndex2) {
            prev = current;

            if (i < m && (j >= n || nums1[i] <= nums2[j])) {
                current = nums1[i];
                i++;
            } else {
                current = nums2[j];
                j++;
            }

            count++;
        }

        if (totalLength % 2 == 0)
            return (prev + current) / 2.0;
        else
            return current;
    }
}
