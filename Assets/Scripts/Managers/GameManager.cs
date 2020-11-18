using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : Manager<GameManager>
{
    private int _deathCount = 0;
    private int _starCount = 0;
    public bool isPhonePlay = false;

    public PlayerControls Controls = null;
    
    public Player GetPlayer() => GameObject.FindObjectOfType<Player>();
    public void AddDeath() => DeathCount += 1;
    public void RemoveStar() => StarCount -= 1;
    public bool HaveStar() => StarCount > 0;

    private void OnEnable()
    {
        if (_instance != null)
            Destroy(gameObject);
        else
        {
            DontDestroyOnLoad(gameObject);
            SetupInputs();
        }
    }

    protected override void xAwake()
    {
    }

    private void SetupInputs()
    {
        Controls = new PlayerControls();
        Controls.MainGameplay.Enable();
        Controls.MainGameplay.Pause.started += (ctx) => Pause();
    }

    public void Pause() => GetHUD().PauseMenu.Pause();
    public void Resume() => GetHUD().PauseMenu.Continue();

    public Hud GetHUD() => GameObject.FindObjectOfType<Hud>();
    public CustomScenesManager GetSceneManager() => GameObject.FindObjectOfType<CustomScenesManager>();

    public int DeathCount
    {
        get
        {
            return _deathCount;
        }
        set
        {
            GetHUD()?.SetDeathCount(value);
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
            GetHUD().SetStarCount(value);
            _starCount = value;
        }
    }
}
