using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeScale : MonoBehaviour
{
    int time = 60;
    public Text timeShow;

    void Start()
    {
        time = PlayerPrefs.GetInt("time");
        timeShow.text = time +"";
        InvokeRepeating("timer", 1, 1);
    }

    public void timer()
    {
        time--;
        timeShow.text = time.ToString();
        if(time == 0)
        {
            CancelInvoke("timer");
        }
    }
}