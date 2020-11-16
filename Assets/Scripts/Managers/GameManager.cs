using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : Manager<GameManager>
{
    private int _deathCount = 0;
    private int _starCount = 0;
    
    public Player GetPlayer() => GameObject.FindObjectOfType<Player>();

    public void AddDeath() => DeathCount += 1;
    public void RemoveStar() => StarCount -= 1;
    public bool HaveStar() => StarCount > 0;

    private void Awake()
    {
        DontDestroyOnLoad(this);
    }

    public int DeathCount
    {
        get
        {
            return _deathCount;
        }
        set
        {
            HudManager.instance.SetDeathCount(value);
            _deathCount = value;
        }
    }

    public int StarCount
    {
        get
        {
            return _starCount;
        }
        set
        {
            HudManager.instance.SetStarCount(value);
            _starCount = value;
        }
    }
}
