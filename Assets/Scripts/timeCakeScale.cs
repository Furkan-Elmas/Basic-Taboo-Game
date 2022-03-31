using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timeCakeScale : MonoBehaviour
{
    float totalScore = 60.0f;
    float nowScore = 60.0f;
    public Slider showCake;
    void Start()
    {
        totalScore = PlayerPrefs.GetInt("time");
        nowScore = PlayerPrefs.GetInt("time");
        InvokeRepeating("cakeFill", 1, 1);
    }

    // Update is called once per frame
    void cakeFill()
    {
        nowScore = nowScore - 1f;
        showCake.value = nowScore / totalScore;
    }
}
