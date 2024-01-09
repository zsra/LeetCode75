namespace LeetCode75.Main.HashMapAndSet;

public class FindTheDifferenceOfTwoArrays
{
    public IList<IList<int>> FindDifference(int[] nums1, int[] nums2)
    {
        var nums1Set = nums1.ToHashSet();
        var nums2Set = nums2.ToHashSet();

        nums1Set.ExceptWith(nums2.ToHashSet());
        nums2Set.ExceptWith(nums1.ToHashSet());

        return new List<IList<int>>
        {
            nums1Set.ToList(),
            nums2Set.ToList()
        };
    }
}
