using strange.extensions.mediation.impl;
using TMPro;
using UnityEngine.UI;

public class GameView : View
{
    public TMP_Text scoreText;
    public Button AddScore;

    public void UpdateScore(int score)
    {
        scoreText.text = "Score: " + score;
    }
}