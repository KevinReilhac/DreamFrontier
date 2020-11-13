using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NaughtyAttributes;

public class RainbowColor : MonoBehaviour
{
    [SerializeField] private Gradient colorGradient = null;
    [SerializeField] private float speed = 1f;
    [Header("Debug")]
    [SerializeField] private bool isActive = false;
    [Space]
    [SerializeField] [ReadOnly] private Color color = Color.white;

    private float _key = 0f;

    private void Start()
    {
        isActive = true;
    }

    private void Update()
    {
        if (isActive && colorGradient != null)
        {
            _key = Mathf.InverseLerp(-1, 1, Mathf.Sin(Time.time * speed));
            color = colorGradient.Evaluate(_key);
        }
    }

    public Color GetColor() => color;
}
