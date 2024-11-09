using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public void GoToMain()
    {
        SceneManager.LoadScene("Equestria");
    }
    public void GoToCredits()
    {
        SceneManager.LoadScene("Creditos");
    }

    public void CloseGame()
    {
        Application.Quit();
    }
}
