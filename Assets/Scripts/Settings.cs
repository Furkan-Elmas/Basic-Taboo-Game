using UnityEngine;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{
    public Image Button_60,Button_90,Button_120,Button_2,Button_3,Button_4,Button_20,Button_30,Button_40,Button_Easy,Button_Medium,Button_Hard;

    public void Update()
    {
        if (PlayerPrefs.GetInt("time") == 60)
        {
            Button_60.color = Color.yellow;
        }
        else if (PlayerPrefs.GetInt("time") != 60)
        {
            Button_60.color = Color.HSVToRGB(184 / 360f, 81 / 100f, 89 / 100f);
        }

        if (PlayerPrefs.GetInt("time") == 90)
        {
            Button_90.color = Color.yellow;
        }
        else if (PlayerPrefs.GetInt("time") != 90)
        {
            Button_90.color = Color.HSVToRGB(184 / 360f, 81 / 100f, 89 / 100f);
        }

        if (PlayerPrefs.GetInt("time") == 120)
        {
            Button_120.color = Color.yellow;
        }
        else if (PlayerPrefs.GetInt("time") != 120)
        {
            Button_120.color = Color.HSVToRGB(184 / 360f, 81 / 100f, 89 / 100f);
        }

        if (PlayerPrefs.GetInt("passright") == 2)
        {
            Button_2.color = Color.yellow;
        }
        else if (PlayerPrefs.GetInt("passright") != 2)
        {
            Button_2.color = Color.HSVToRGB(184 / 360f, 81 / 100f, 89 / 100f);
        }

        if (PlayerPrefs.GetInt("passright") == 3)
        {
            Button_3.color = Color.yellow;
        }
        else if (PlayerPrefs.GetInt("passright") != 3)
        {
            Button_3.color = Color.HSVToRGB(184 / 360f, 81 / 100f, 89 / 100f);
        }

        if (PlayerPrefs.GetInt("passright") == 4)
        {
            Button_4.color = Color.yellow;
        }
        else if (PlayerPrefs.GetInt("passright") != 4)
        {
            Button_4.color = Color.HSVToRGB(184 / 360f, 81 / 100f, 89 / 100f);
        }
        if (PlayerPrefs.GetInt("winscore") == 20)
        {
            Button_20.color = Color.yellow;
        }
        else if (PlayerPrefs.GetInt("winscore") != 20)
        {
            Button_20.color = Color.HSVToRGB(184 / 360f, 81 / 100f, 89 / 100f);
        }
        if (PlayerPrefs.GetInt("winscore") == 30)
        {
            Button_30.color = Color.yellow;
        }
        else if (PlayerPrefs.GetInt("winscore") != 30)
        {
            Button_30.color = Color.HSVToRGB(184 / 360f, 81 / 100f, 89 / 100f);
        }
        if (PlayerPrefs.GetInt("winscore") == 40)
        {
            Button_40.color = Color.yellow;
        }
        else if (PlayerPrefs.GetInt("winscore") != 40)
        {
            Button_40.color = Color.HSVToRGB(184 / 360f, 81 / 100f, 89 / 100f);
        }
        if (PlayerPrefs.GetString("difficulty") == "Easy")
        {
            Button_Easy.color = Color.yellow;
        }
        else if (PlayerPrefs.GetString("difficulty") != "Easy")
        {
            Button_Easy.color = Color.HSVToRGB(184 / 360f, 81 / 100f, 89 / 100f);
        }
        if (PlayerPrefs.GetString("difficulty") == "Medium")
        {
            Button_Medium.color = Color.yellow;
        }
        else if (PlayerPrefs.GetString("difficulty") != "Medium")
        {
            Button_Medium.color = Color.HSVToRGB(184 / 360f, 81 / 100f, 89 / 100f);
        }
        if (PlayerPrefs.GetString("difficulty") == "Hard")
        {
            Button_Hard.color = Color.yellow;
        }
        else if (PlayerPrefs.GetString("difficulty") != "Hard")
        {
            Button_Hard.color = Color.HSVToRGB(184 / 360f, 81 / 100f, 89 / 100f);
        }
    }

    public void sixtySec()
    {
        int time = 60;
        PlayerPrefs.SetInt("time",time);
    }
    public void ninetySec()
    {
        int time = 90;
        PlayerPrefs.SetInt("time", time);
    }
    public void hundredTwentySec()
    {
        int time = 120;
        PlayerPrefs.SetInt("time", time);
    }
    public void twoRight()
    {
        int passRight = 2;
        PlayerPrefs.SetInt("passright", passRight);
    }
    public void threeRight()
    {
        int passRight = 3;
        PlayerPrefs.SetInt("passright", passRight);
    }
    public void fourRight()
    {
        int passRight = 4;
        PlayerPrefs.SetInt("passright", passRight);

    }
    public void twentyScore()
    {
        int winScore = 20;
        PlayerPrefs.SetInt("winscore", winScore);
    }
    public void thirtyScore()
    {
        int winScore = 30;
        PlayerPrefs.SetInt("winscore", winScore);
    }
    public void fourtyScore()
    {
        int winScore = 40;
        PlayerPrefs.SetInt("winscore", winScore);
    }
    public void easyDifficulty()
    {
        string difficulty = "Easy";
        PlayerPrefs.SetString("difficulty", difficulty);
    }
    public void mediumDifficulty()
    {
        string difficulty = "Medium";
        PlayerPrefs.SetString("difficulty", difficulty);
    }
    public void hardDifficulty()
    {
        string difficulty = "Hard";
        PlayerPrefs.SetString("difficulty", difficulty);
    }
}
