using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseScript : MonoBehaviour
{
    public GameObject PauseUI;

    private bool paused = false;

    private void Start()
    {
        PauseUI.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetButtonDown("Pause"))
        {
            paused = !paused;
        }

        if (paused)
        {
            PauseUI.SetActive(true);
            Time.timeScale = 0;
        }
        if (!paused)
        {
            PauseUI.SetActive(false);
            Time.timeScale = 1;
        }
    }
    public void ButtonPause()
        {
            paused = true;
        }

    public void Resume()
    {
        paused = false;
    }

    public void keluar()
    {
        SceneManager.LoadScene("mainmenu");
    }
}


