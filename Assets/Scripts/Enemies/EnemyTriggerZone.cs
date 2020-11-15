using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTriggerZone : MonoBehaviour
{
    [SerializeField] private Unicorn unicorn = null;

    private GameObject target = null;
    private Vector2 direction = Vector2.zero;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            target = collision.gameObject;
            if (RaycastTest(target))
            unicorn.OnDetectPlayer();
        }
    }

    private bool RaycastTest(GameObject obj)
    {
        direction = (obj.transform.position - transform.position).normalized;
        RaycastHit2D hit = Physics2D.Raycast(transform.position, direction);

        return (hit.collider.gameObject == obj);
    }

    private void OnDrawGizmos()
    {
        if (!target)
            return;
        Gizmos.color = Color.red;
        Gizmos.DrawLine(transform.position, (transform.position + (Vector3)direction) * 2);
    }
}
