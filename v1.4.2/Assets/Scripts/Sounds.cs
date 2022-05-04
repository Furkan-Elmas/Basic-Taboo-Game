using UnityEngine;

public class Sounds : MonoBehaviour
{
    [SerializeField] private AudioSource buttonAudio;
    [SerializeField] private AudioClip clickSound, passSound, correctSound, tabooSound;

    private void Start()
    {
        buttonAudio = GameObject.Find("ButtonClickSound").GetComponent<AudioSource>();
    }

    public void PassSoundEffect()
    {
        buttonAudio.PlayOneShot(passSound);
    }
    public void CorrectSoundEffect()
    {
        buttonAudio.PlayOneShot(correctSound);
    }
    public void TabooSoundEffect()
    {
        buttonAudio.PlayOneShot(tabooSound);
    }
    public void ClickSoundEffect()
    {
        buttonAudio.PlayOneShot(clickSound);
    }
}
