﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class backscript : MonoBehaviour
{
    public void back()
    {
        SceneManager.LoadScene("mainmenu");
    }

    public void resume()
    {
        Time.timeScale = 1;
    }
}
