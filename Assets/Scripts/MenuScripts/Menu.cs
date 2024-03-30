using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject Main;
    public GameObject HowtoPlay;

    public void LoadLevel()
    {
        SceneManager.LoadScene(1);
    }

    public void HowPlay()
    {
         Main.gameObject.SetActive(false);
         HowtoPlay.gameObject.SetActive(true);
    }

    public void Min()
    {
        HowtoPlay.gameObject.SetActive(false);
        Main.gameObject.SetActive(true);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
