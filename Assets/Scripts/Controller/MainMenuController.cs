using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuController : MonoBehaviour
{
    public void PlayGameButton()
    {
        Application.LoadLevel("Level 1");
    }
    public void QuitGameButton()
    {
        Application.Quit();
    }
}
