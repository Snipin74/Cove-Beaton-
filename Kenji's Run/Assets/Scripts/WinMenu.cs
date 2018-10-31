using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinMenu : MonoBehaviour {

    public string playMenuLevel;
    public string playGameLevel;


    public void MainMenu()
    {
        Application.LoadLevel(playMenuLevel);
    }

    public void NextLevel()
    {
        Application.LoadLevel(playGameLevel);
    }
}
