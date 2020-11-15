using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScreen : MonoBehaviour
{
    void Start()
    {
        Invoke("LoadMenu", 5f);
    }

    private void LoadMenu()
    {
        SceneManager.LoadScene("TitleScreen");
    }
}
