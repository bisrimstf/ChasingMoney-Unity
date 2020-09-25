using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class retryScript : MonoBehaviour
{

    public void RetryGame()
    {
        SceneManager.LoadScene("gameplay");
        ScoreTextScript.coinAmount = 0;
        //Time.timeScale = 1;
    }
}
