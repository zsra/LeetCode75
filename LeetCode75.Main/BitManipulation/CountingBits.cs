namespace LeetCode75.Main.BitManipulation;

internal class CountingBits
{
    public int[] CountBitsMethod(int n)
    {
        int[] numberOf1BitsArray = new int[n + 1];
        for (int i = 0; i < n + 1; i++)
        {
            string binary = Convert.ToString(i, 2);
            numberOf1BitsArray[i] = binary.Count(x => x == '1');
        }

        return numberOf1BitsArray;
    }
}
