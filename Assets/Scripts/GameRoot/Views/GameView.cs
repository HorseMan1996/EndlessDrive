using strange.extensions.mediation.impl;
using TMPro;
using UnityEngine.UI;

public class GameView : View
{
    public TMP_Text ScoreText;
    public Button AddScore;

    public void UpdateScore(int score)
    {
        ScoreText.text = "Score: " + score;
    }
}