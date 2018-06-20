using UnityEngine;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour {
    public Text blueScore;
    public Text redScore;

    public void goalScored(int team)
    {
        int currScore;
        if (team == 1)
        {
            currScore = int.Parse(blueScore.text);
            currScore++;
            blueScore.text = currScore.ToString("0");

        }
        else
        {
            currScore = int.Parse(redScore.text);
            currScore++;
            redScore.text = currScore.ToString("0");
        }
    }

}
