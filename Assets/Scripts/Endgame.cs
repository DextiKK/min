using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Endgame : MonoBehaviour
{
    public GameObject gameplayUI;
    public GameObject gameWin;
    public PlayerController playerController;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
            Cursor.lockState = CursorLockMode.Confined;
            Cursor.visible = true;
            Score.enemys = 0;
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        gameplayUI.SetActive(false);
        gameWin.SetActive(true);
        playerController.enabled = false;
        GetComponent<FireWallCaster>().enabled = false;
        GetComponent<GrenadeCaster>().enabled = false;
        GetComponent<CameraRotation>().enabled = false;
    }
}
