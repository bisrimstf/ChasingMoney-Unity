using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighscoreScript : MonoBehaviour
{
    public Text highscoreText;

    void Start()
    {
        highscoreText.text = "Highscore : " + ((int)PlayerPrefs.GetFloat("Highscore")).ToString();
    }
}
