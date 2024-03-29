﻿namespace LeetCode75.Main.ArraysAndStrings;

public class CanPlaceFlowers
{
    public bool CanPlaceFlowersMethod(int[] flowerbed, int n)
    {
        int count = 0;
        int i = 0;

        while (i < flowerbed.Length)
        {
            if (flowerbed[i] == 0 && (i == 0 || flowerbed[i - 1] == 0) &&
                (i == flowerbed.Length - 1 || flowerbed[i + 1] == 0))
            {
                flowerbed[i] = 1;
                count++;
            }
            i++;
        }

        return count >= n;
    }
}
