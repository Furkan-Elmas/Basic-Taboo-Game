using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TeamTurn : MonoBehaviour
{
    public Text text,firstTeam,secondTeam,firstTScore,secondTScore;
    int winScore = 30,firstTeamScore,SecondTeamScore;
    public GameObject cntButton, restartButton, backButton;

    void Start()
    {
        cntButton.SetActive(true);
        restartButton.SetActive(false);
        backButton.SetActive(false);

        winScore = PlayerPrefs.GetInt("winscore");
        firstTeamScore = PlayerPrefs.GetInt("team1score");
        SecondTeamScore = PlayerPrefs.GetInt("team2score");
        
        if (firstTeamScore >= winScore)
        {
            text.text = PlayerPrefs.GetString("teamOne") + " has won!";
            firstTeam.text = PlayerPrefs.GetString("teamOne");
            secondTeam.text = PlayerPrefs.GetString("teamTwo");
            firstTScore.text = PlayerPrefs.GetInt("team1score") + "";
            secondTScore.text = PlayerPrefs.GetInt("team2score") + "";
            cntButton.SetActive(false);
            restartButton.SetActive(true);
            backButton.SetActive(true);
        }
        else if (SecondTeamScore >= winScore)
        {
            text.text = PlayerPrefs.GetString("teamTwo") + " has won!";
            firstTeam.text = PlayerPrefs.GetString("teamOne");
            secondTeam.text = PlayerPrefs.GetString("teamTwo");
            firstTScore.text = PlayerPrefs.GetInt("team1score") + "";
            secondTScore.text = PlayerPrefs.GetInt("team2score") + "";
            cntButton.SetActive(false);
            restartButton.SetActive(true);
            backButton.SetActive(true);
        }
        else
        {
            text.text = PlayerPrefs.GetString("turn") + " Your Turn";
            firstTeam.text = PlayerPrefs.GetString("teamOne");
            secondTeam.text = PlayerPrefs.GetString("teamTwo");
            firstTScore.text = PlayerPrefs.GetInt("team1score") + "";
            secondTScore.text = PlayerPrefs.GetInt("team2score") + "";
            PlayerPrefs.SetInt("gamescore", 0);
        }
    }
}