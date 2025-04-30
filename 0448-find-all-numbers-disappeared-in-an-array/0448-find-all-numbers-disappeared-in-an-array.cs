public class Solution {
    public IList<int> FindDisappearedNumbers(int[] nums) {
       List<int>list=new List<int>();
       for(int i=1;i<=nums.Length;i++){ list.Add(i); }
       var rus = list.Except(nums).ToList();
       return rus;
    }
}