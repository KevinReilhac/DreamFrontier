using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Hud : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI deathCount;
    [SerializeField] private TextMeshProUGUI starCount;

    [SerializeField] public PauseMenu PauseMenu = null;

    public void SetDeathCount(int count)
    {
        deathCount.text = count.ToString();
    }

    public void SetStarCount(int count)
    {
        starCount.text = count.ToString();
    }
}
