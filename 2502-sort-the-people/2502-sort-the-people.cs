public class Solution {
    public string[] SortPeople(string[] names, int[] heights) {
        int n = names.Length;

        (int height, string name)[] people = new (int, string)[n];
        for (int i = 0; i < n; i++) {
            people[i] = (heights[i], names[i]);
        }

        Array.Sort(people, (a, b) => b.height.CompareTo(a.height));

        string[] result = new string[n];
        for (int i = 0; i < n; i++) {
            result[i] = people[i].name;
        }

        return result;
    }
}
