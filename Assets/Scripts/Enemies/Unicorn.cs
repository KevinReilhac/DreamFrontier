using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NaughtyAttributes;
using UnityEngine.Experimental.Rendering.Universal;
using UnityEngine.SceneManagement;
using Pathfinding;

public class Unicorn : MonoBehaviour
{
    [Header("Components")]
    [SerializeField] private AnimMovements animMovement = null;
    [SerializeField] private Light2D cornLight = null;
    [SerializeField] private AIPath ai;
    [SerializeField] private Animator animator = null;
    [Header("Gameplay")]
    [SerializeField] private bool isBlink = false;
    [SerializeField] private float stunTime = 3f;

    [SerializeField] [Dropdown("GetVectorStart")]
    private Vector2 defaultDirection = new Vector2(1, 0);

    private bool _isStun = false;

    private DropdownList<Vector2> GetVectorStart()
    {
        return new DropdownList<Vector2>()
        {
            { "Right",   Vector2.right },
            { "Left",    Vector2.left },
            { "Up",      Vector2.up },
            { "Down",    Vector2.down },
        };
    }


    private void Awake()
    {
        SetDefaultDirection();
    }

    private void SetDefaultDirection()
    {
        animMovement.SetDirection(defaultDirection);
    }

    public void Stun()
    {
        StartCoroutine(StunCoroutine());
    }

    private IEnumerator StunCoroutine()
    {
        float oldMaxSpeed = 0;
        if (ai)
            oldMaxSpeed = ai.maxSpeed;

        animator.SetBool("isStun", true);
        cornLight.enabled = false;
        if (ai)
            ai.maxSpeed = 0;
        _isStun = true;
        yield return new WaitForSeconds(stunTime);
        _isStun = false;
        if (ai)
            ai.maxSpeed = oldMaxSpeed;
        cornLight.enabled = true;
        animator.SetBool("isStun", false);
    }

    private void Update()
    {
         UpdateLightOrientation();
    }

    private void UpdateLightOrientation()
    {
        if (cornLight == null)
            return;
        Vector2 velocity = animMovement.GetDirection();
        Vector2 velocity4 = velocity.Get4Direction();
        
        float angle = 0;

        if (velocity.magnitude < 0.3f)
            return;
        if (velocity4.x > 0 && velocity4.y == 0)
            angle = 90;
        if (velocity4.x < 0 && velocity4.y == 0)
            angle = 270;
        if (velocity4.y > 0 && velocity4.x == 0)
            angle = 180;
        if (velocity4.y < 0 && velocity4.x == 0)
            angle = 0;

        cornLight.transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }

    public void OnDetectPlayer()
    {
        animator.SetBool("isAngry", true);
        if (ai)
            ai.maxSpeed = 0f;
        GameManager.instance.GetPlayer().Kill();
    }

    public void SetCornLight(bool state)
    {
        cornLight.gameObject.SetActive(state);
    }

    public bool IsStun
    {
        get => _isStun;
    }

    public bool IsBlink
    {
        get => isBlink;
    }
}
