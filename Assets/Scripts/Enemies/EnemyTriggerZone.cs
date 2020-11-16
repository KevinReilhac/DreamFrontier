using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTriggerZone : MonoBehaviour
{
    [SerializeField] private Unicorn unicorn = null;

    private GameObject _target = null;
    private Vector2 _direction = Vector2.zero;
    private bool _isPlayerDetected = false;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (_isPlayerDetected)
            return;
        if (collision.CompareTag("Player"))
        {
            _target = collision.gameObject;
            if (RaycastTest(_target))
                unicorn.OnDetectPlayer();
            _isPlayerDetected = true;
        }
    }

    private bool RaycastTest(GameObject obj)
    {
        _direction = (obj.transform.position - transform.position).normalized;
        RaycastHit2D hit = Physics2D.Raycast(transform.position, _direction);

        return (hit.collider.gameObject == obj);
    }

    private void OnDrawGizmos()
    {
        if (!_target)
            return;
        Gizmos.color = Color.red;
        Gizmos.DrawLine(transform.position, (transform.position + (Vector3)_direction) * 2);
    }
}
