using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class SceneLoad : MonoBehaviour
{
    public InputField teamOne,teamTwo;

    public void goToTeamNames()
    {
        SceneManager.LoadScene(1);
    }
    public void goToBack()
    {
        SceneManager.LoadScene(0);
    }
    public void goToGame()
    {
        if (teamOne.text == "" || teamTwo.text == "")
            return;
        else
        {
            SceneManager.LoadScene(2);
        }
    }
    public void ContinueButton()
    {
        SceneManager.LoadScene(2);
    }
    public void goToHelp()
    {
        SceneManager.LoadScene(4);
    }
    public void goToSetting()
    {
        SceneManager.LoadScene(5);
    }
    public void dataRead()
    {
        PlayerPrefs.SetString("teamOne", teamOne.text);
        PlayerPrefs.SetString("teamTwo", teamTwo.text);
        PlayerPrefs.SetString("turn", teamOne.text);
        PlayerPrefs.SetInt("team1score", 0);
        PlayerPrefs.SetInt("team2score", 0);
        PlayerPrefs.SetInt("count", 0);
        PlayerPrefs.SetInt("gamescore", 0);
        PlayerPrefs.DeleteKey("wordindex");
        PlayerPrefs.DeleteKey("wordcount");
        int count = PlayerPrefs.GetInt("count");
    }
    public void gameRestart()
    {
        string teamone = PlayerPrefs.GetString("teamOne");
        PlayerPrefs.SetString("turn", teamone);
        PlayerPrefs.SetInt("team1score", 0);
        PlayerPrefs.SetInt("team2score", 0);
        PlayerPrefs.SetInt("count", 0);
        PlayerPrefs.SetInt("gamescore", 0);
        PlayerPrefs.DeleteKey("wordindex");
        PlayerPrefs.DeleteKey("wordcount");
    }
    public void dataRenovation()
    {
        if (PlayerPrefs.GetInt("time") == 0)
        {
            PlayerPrefs.SetInt("time", 60);
        }
        if (PlayerPrefs.GetInt("passright") == 0)
        {
            PlayerPrefs.SetInt("passright", 2);
        }
        if (PlayerPrefs.GetInt("winscore") == 0)
        {
            PlayerPrefs.SetInt("winscore", 20);
        }
        if (PlayerPrefs.GetString("difficulty") == string.Empty)
        {
            PlayerPrefs.SetString("difficulty", "Easy");
        }
    }
    public void dataClear()
    {
        int countE = PlayerPrefs.GetInt("wordcounteasy");
        int countM = PlayerPrefs.GetInt("wordcountmedium");
        int countH = PlayerPrefs.GetInt("wordcounthard");
        for (int i = 0; i < countE; i++)
        {
            PlayerPrefs.DeleteKey("wordindexeasy" + i);
        }
        for (int i = 0; i < countM; i++)
        {
            PlayerPrefs.DeleteKey("wordindexmedium" + i);
        }
        for (int i = 0; i < countH; i++)
        {
            PlayerPrefs.DeleteKey("wordindexhard" + i);
        }
    }
}