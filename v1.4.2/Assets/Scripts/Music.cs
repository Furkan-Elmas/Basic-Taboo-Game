using UnityEngine;
using UnityEngine.SceneManagement;

public class Music : MonoBehaviour
{
    private static Music _audioCheck;

    private Scene _currentScene;

    public AudioSource music;

    private void Awake()
    {
        DontDestroyOnLoad(this);

        if (_audioCheck == null)
        {
            _audioCheck = this;
        }
        else
        {
            DestroyImmediate(gameObject);
        }
    }
    private void Update()
    {
        _currentScene = SceneManager.GetActiveScene();

        if (_currentScene == SceneManager.GetSceneByBuildIndex(2))
        {
            Destroy(gameObject);
        }
    }
}
