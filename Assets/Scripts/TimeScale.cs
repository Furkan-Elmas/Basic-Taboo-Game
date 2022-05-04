using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeScale : MonoBehaviour
{
    [SerializeField] private Text timeShow;

    private TeamChange TeamChange;

    private int _time;

    void Start()
    {
        TeamChange = GetComponent<TeamChange>();

        _time = PlayerPrefs.GetInt("time");
        timeShow.text = _time + "";
        InvokeRepeating("timer", 1, 1);
    }

    public void timer()
    {
        _time--;
        timeShow.text = _time.ToString();
        if(_time == 0)
        {
            TeamChange.ChangePlayerTeam();
            SceneManager.LoadScene(3);
            CancelInvoke("timer");
        }
    }
}