using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StarCollectible : ACollectible
{
    [SerializeField] private int starCount = 0;
    [SerializeField] private TextMeshPro text = null;

    private void Start()
    {
        text.text = starCount.ToString();
    }

    protected override void OnCollect()
    {
        GameManager.instance.StarCount += starCount;
    }
}
