namespace LeetCode75.Main.Queue;

public class Dota2Senate
{
    public string PredictPartyVictory(string senate)
    {
        Queue<char> senators = new(senate);
        int countR = senate.Count(x => x == 'R');
        int countD = senate.Length - countR;

        int scale = 0;

        while (countR > 0 && countD > 0)
        {
            char senator = senators.Dequeue();

            if (senator == 'R')
            {
                if (scale >= 0)
                {
                    countD--;
                    senators.Enqueue(senator);
                }
                scale++;
            }
            else
            {
                if (scale <= 0)
                {
                    countR--;
                    senators.Enqueue(senator);
                }
                scale--;
            }
        }

        return countR == 0 ? "Dire" : "Radiant";
    }
}
