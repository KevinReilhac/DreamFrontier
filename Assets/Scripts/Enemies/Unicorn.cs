using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NaughtyAttributes;
using UnityEngine.Experimental.Rendering.Universal;
using UnityEngine.SceneManagement;
using Pathfinding;

public class Unicorn : MonoBehaviour
{
    [SerializeField] AnimMovements animMovement = null;
    [SerializeField] Light2D cornLight = null;
    [SerializeField] private bool isBlinking = false;
    [SerializeField] private float stunTime = 3f;
    [SerializeField] private AIPath ai;
    [SerializeField] private Vector2 defaultDirection = new Vector2(1, 0);
    [SerializeField] [ShowIf("isBlinking")] private float blinkTime = 3f;
    [SerializeField] private Animator animator = null;

    private bool _isStun = false;

    private void Awake()
    {
        if (isBlinking)
            StartCoroutine(BlinkCoroutine());
    }

    private void Start()
    {
        animator.SetFloat("SpeedX", defaultDirection.x);
        animator.SetFloat("SpeedY", defaultDirection.y);
        UpdateLightOrientation();
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

    private void OnDestroy()
    {
    }

    private void Update()
    {
        if (animMovement)
            UpdateLightOrientation();
    }

    private void UpdateLightOrientation()
    {
        if (cornLight == null || animMovement == null)
            return;
        Vector2 velocity = animMovement ? animMovement.GetDirection() : defaultDirection;
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
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
