using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class showData : MonoBehaviour
{
    public Text NameText = null;
    //public Text LivesText;
    public Text rotationText;
    //public Text lcoreText;
    public Text HighScoreText;
    public Text RoundsText;

    private void Awake()
    {
        NameText.text = keepData.PlayerName;
        // LivesText.text = keepData.PlayerLives.ToString();
        rotationText.text = keepData.CubeRotationMultiplier.ToString();
      
        RoundsText.text = "Rounds: " + keepData.RoundsToPlay.ToString();
    }


    private void Update()
    {
        HighScoreText.text = "highscore : "+PlayerController.count.ToString();
    }
}
