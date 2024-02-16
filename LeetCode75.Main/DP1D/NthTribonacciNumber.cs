namespace LeetCode75.Main.DP1D;

internal class NthTribonacciNumber
{
    public int Tribonacci(int n)
    {
        switch (n)
        {
            case 1:
            case 2:
                return 1;
        }

        int val0 = 0;
        int val1 = 1;
        int val2 = 1;
        int nextNumber = 0;
        
        for (int i = 2; i < n; i++)
        {
            nextNumber = val0 + val1 + val2;
            val0 = val1;
            val1 = val2;
            val2 = nextNumber;
        }

        return nextNumber;
    }
}
