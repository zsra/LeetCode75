namespace LeetCode75.Main.HashMapAndSet;

public class UniqueNumberOfOccurrences
{
    public bool UniqueOccurrences(int[] arr)
    {
        Dictionary<int, int> counts = [];

        for (int i = 0; i < arr.Length; i++)
        {
            counts[arr[i]] = counts.TryGetValue(arr[i], out int value) 
                ? ++value 
                : 0;
        }

        HashSet<int> collection = [];

        foreach (var item in counts)
        {
            if(!collection.Add(item.Value))
            {
                return false;
            }
        }

        return true;
    }
}
