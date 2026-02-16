using UnityEngine;

[System.Serializable]
public class Data
{
    public int[] Highscore;

    public Data(Player player, GameManager manager)
    {
        Highscore = new int[player.Scores.Length];

        int counter = 0;

        foreach (var item in player.Scores)
        {
            Highscore[counter] = item;

            counter++;
        }
    }
}
