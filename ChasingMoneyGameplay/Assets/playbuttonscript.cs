using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playbuttonscript : MonoBehaviour
{
    public void play()
    {
        ScoreTextScript.coinAmount = 0;
        SceneManager.LoadScene("gameplay");
    }
}
