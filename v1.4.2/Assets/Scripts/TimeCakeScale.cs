using UnityEngine;
using UnityEngine.UI;

public class TimeCakeScale : MonoBehaviour
{
    [SerializeField] private Slider showCake;

    private float _totalScore = 60.0f;
    private float _currentScore = 60.0f;

    void Start()
    {
        _totalScore = PlayerPrefs.GetInt("time");
        _currentScore = PlayerPrefs.GetInt("time");
        InvokeRepeating("CakeFill", 1, 1);
    }

    // Update is called once per frame
    void CakeFill()
    {
        _currentScore = _currentScore - 1f;
        showCake.value = _currentScore / _totalScore;
    }
}
