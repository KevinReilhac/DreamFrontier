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
    [SerializeField] AnimMovements animMovement = null;
    [SerializeField] Light2D cornLight = null;
    [SerializeField] private AIPath ai;
    [SerializeField] private Animator animator = null;
    [Header("Gameplay")]
    [SerializeField] private bool isBlinking = false;
    [SerializeField] private float stunTime = 3f;
    [SerializeField] [ShowIf("isBlinking")] private float blinkTime = 3f;

    [SerializeField] [Dropdown("GetVectorStart")] [OnValueChanged("SetDefaultDirection")]
    private Vector2 defaultDirection = new Vector2(1, 0);

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

    private bool _isStun = false;

    private void OnEnable()
    {
        SetDefaultDirection();
    }

    private void Awake()
    {
        if (isBlinking)
            StartCoroutine(BlinkCoroutine());
    }

    private void Start()
    {
        SetDefaultDirection();
    }

    private IEnumerator BlinkCoroutine()
    {
        yield return new WaitForSeconds(Random.Range(0, 2f));
        while (true)
        {
            yield return new WaitForSeconds(blinkTime);
            if (!_isStun)
                cornLight.enabled = !cornLight.enabled;
        }
    }

    public void Stun()
    {
        Debug.LogWarning("AAAA");
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
        if (animMovement)
            UpdateLightOrientation();
    }

    private void SetDefaultDirection()
    {
        UpdateLightOrientation(defaultDirection);
    }

    private void UpdateLightOrientation(Vector2? dir = null)
    {
        if (cornLight == null)
            return;
        Vector2 velocity = dir.HasValue ? dir.Value : animMovement.GetDirection();
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
        SceneManager.LoadScene("Level1");
    }

}
