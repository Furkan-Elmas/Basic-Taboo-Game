using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickSoundEffect : MonoBehaviour
{
    private static ClickSoundEffect _clickSoundSource;

    private void Awake()
    {
        DontDestroyOnLoad(this);

        if (_clickSoundSource == null)
        {
            _clickSoundSource = this;
        }
        else
        {
            DestroyImmediate(gameObject);
        }
    }
}
