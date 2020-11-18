using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NaughtyAttributes;

public class PlayOnPhoneButton : MonoBehaviour
{
    [Button("Play")]
    public void Play()
    {
        GameManager.instance.isPhonePlay = true;
        GameManager.instance.GetSceneManager().LoadNextScene();
    }
}
