using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScreen : MonoBehaviour
{
    public GameObject panel, resumeButton, mainMenuButton;

    void Start()
    {
        panel.SetActive(false);
        resumeButton.SetActive(false);
        mainMenuButton.SetActive(false);
    }

    public void panelShow()
    {
        Time.timeScale = 0;
        panel.SetActive(true);
        resumeButton.SetActive(true);
        mainMenuButton.SetActive(true);
    }
    public void resumeButtonClick()
    {
        Time.timeScale = 1;
        panel.SetActive(false);
        resumeButton.SetActive(false);
        mainMenuButton.SetActive(false);
    }
    public void mainMenuClick()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
}
