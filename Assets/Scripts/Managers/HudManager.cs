using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HudManager : Manager<HudManager>
{
    [SerializeField] private TextMeshProUGUI deathCount;
    [SerializeField] private TextMeshProUGUI starCount;

    public void SetDeathCount(int count)
    {
        deathCount.text = count.ToString();
    }

    public void SetStarCount(int count)
    {
        starCount.text = count.ToString();
    }
}
