using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameControllerScript : MonoBehaviour
{
    public int Score;
    public Text scoreText;
    void Update()
    {
        //update Score TXT
        scoreText.text = "SCORE : " + Score.ToString() + " / 10";
    }
}
