using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

public class Unicorn : MonoBehaviour
{
    [SerializeField] AnimMovements animMovement = null;
    [SerializeField] Light2D cornLight = null;

    private void Update()
    {
        UpdateLightOrientation();
    }

    private void UpdateLightOrientation()
    {
        if (cornLight == null || animMovement == null)
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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
            Debug.LogWarning("Died");
    }
}
