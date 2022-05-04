using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MusicNSoundSettings : MonoBehaviour
{
    [SerializeField] private GameObject canvas;
    [SerializeField] private GameObject gameManagerObject;

    [SerializeField] private Slider soundVolumeSlider;
    [SerializeField] private Slider musicVolumeSlider;

    private static MusicNSoundSettings _musicNSoundSettings;

    private Scene _currentScene, _previousScene;

    private AudioSource _music;
    private AudioSource _clickSound;

    private void Awake()
    {
        DontDestroyOnLoad(canvas);
        DontDestroyOnLoad(gameManagerObject);

        _previousScene = SceneManager.GetActiveScene();

        if (_musicNSoundSettings == null)
        {
            _musicNSoundSettings = this;
        }
    }

    private void OnEnable()
    {
        _music = GameObject.Find("GameMusic").GetComponent<AudioSource>();
        _clickSound = GameObject.Find("ButtonClickSound").GetComponent<AudioSource>();
    }

    private void Start()
    {
        musicVolumeSlider.value = _music.volume;
        soundVolumeSlider.value = _clickSound.volume;
    }

    private void Update()
    {

        _currentScene = SceneManager.GetActiveScene();

        if (_previousScene != _currentScene)
        {
            Destroy(canvas, 0.5f);
            Destroy(gameManagerObject, 0.5f);
        }
    }

    public void ChangeMusicVolume(float volume)
    {
        _music.volume = volume;
    }

    public void ChangeSoundVolume(float volume)
    {
        _clickSound.volume = volume;
    }
}
