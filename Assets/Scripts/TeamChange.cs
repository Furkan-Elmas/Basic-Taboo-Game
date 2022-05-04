using UnityEngine;
using UnityEngine.UI;

public class TeamChange : MonoBehaviour
{
    [SerializeField] private Text time,team,scoretext;

    private int counter, team1score, team2score,score;
    private string team1, team2;

    private void Start()
    {
        team1 = PlayerPrefs.GetString("teamOne");
        team2 = PlayerPrefs.GetString("teamTwo");
        team.text = PlayerPrefs.GetString("turn");
        counter = PlayerPrefs.GetInt("count");
        scoretext.text = 0 + "";
    }
    public void ChangePlayerTeam()
    {
        if(counter % 2 ==0)
        {
            score = int.Parse(scoretext.text);
            team1score = PlayerPrefs.GetInt("team1score");
            team1score = team1score + score;
            PlayerPrefs.SetInt("team1score", team1score);

            counter++;
            PlayerPrefs.SetInt("count",counter);
            PlayerPrefs.SetString("turn", team2);
        }
        else if(counter%2==1)
        {
            score = int.Parse(scoretext.text);
            team2score = PlayerPrefs.GetInt("team2score");
            team2score = team2score + score;
            PlayerPrefs.SetInt("team2score", team2score);

            counter++;
            PlayerPrefs.SetInt("count", counter);
            PlayerPrefs.SetString("turn", team1);
        }
    }
}