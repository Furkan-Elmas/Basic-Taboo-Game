using UnityEngine;
using UnityEngine.SceneManagement;

public class SoundProtection : MonoBehaviour
{
    [SerializeField] private GameObject canvas;
    [SerializeField] private GameObject gameManager;

    private static SoundProtection _clickSound;
    private Scene _currentScene, _previousScene;

    private void Awake()
    {
        DontDestroyOnLoad(canvas);
        DontDestroyOnLoad(gameManager);

        _previousScene = SceneManager.GetActiveScene();

        if (_clickSound == null)
        {
            _clickSound = this;
        }
    }
    private void Update()
    {
        _currentScene = SceneManager.GetActiveScene();

        if (_previousScene != _currentScene)
        {
            Destroy(canvas,0.5f);
            Destroy(gameManager, 0.5f);
        }
    }
}
