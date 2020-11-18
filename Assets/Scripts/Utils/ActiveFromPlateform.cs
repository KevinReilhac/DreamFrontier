using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveFromPlateform : MonoBehaviour
{
    [SerializeField] private bool windows = true;
    [SerializeField] private bool browser = true;
    [SerializeField] private bool mobile = true;
    [Space]
    [SerializeField] private bool editor = true;

#if UNITY_WEBGL
    private void Start()
    {
        gameObject.SetActive(browser || editor);
    }
#endif

#if UNITY_STANDALONE_WIN
    private void Start()
    {
        gameObject.SetActive(windows || editor);
    }
#endif

#if UNITY_ANDROID
    private void Start()
    {
        gameObject.SetActive(mobile || editor);
    } 
#endif
}
