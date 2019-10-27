using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class keepData : MonoBehaviour
{
    public static string PlayerName = "default name";
    public static bool OversizedBall;
    public static int RoundsToPlay =3;
    public static float PlayerSpeedMultiplier = 1.0f;
    public static int Currentscore = 0;
    public static int HighScore = 0;
    public static float CubeRotationMultiplier = 1.0f;

    public InputField playerName;
    public Toggle ballSize;
    public Dropdown roundsToPlay;
   
    public Slider cubeRotationMultiplier;
    // Start is called before the first frame update
    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    public void Update()
    {
        PlayerName = playerName.text;
    }
    public void BigBall (bool newValue)
    {
        OversizedBall = newValue;
    }
    public void SetRoundsToPlay()
    {
        switch (roundsToPlay.value)
        {
            case 1:
                RoundsToPlay = 1;
                break;
            case 2:
                RoundsToPlay = 2;
                break;
            case 3:
                RoundsToPlay = 3;
                break;
             //   RoundsToPlay = 4;
              //  break;
            default:
                RoundsToPlay = 0;
                break;
        }
    }
   
    public void SetCubeRotationMultiplier()
    {
        CubeRotationMultiplier = cubeRotationMultiplier.value;
    }
}
