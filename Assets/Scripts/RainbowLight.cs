using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;


public class RainbowLight : MonoBehaviour
{
    [SerializeField] private Light2D target = null;
    [SerializeField] private RainbowColor rainbowColor = null;

    private void Awake()
    {
        if (target == null)
            target = GetComponent<Light2D>();
    }

    private void Update()
    {
        target.color = rainbowColor.GetColor();
    }
}
