using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class settingsbutton : MonoBehaviour
{
    public void clicksettings()
    {
        SceneManager.LoadScene("settings");
    }
}
