using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

public class Projectile : MonoBehaviour
{
    [SerializeField] private SpriteRenderer spriteRenderer = null;
    [SerializeField] private TrailRenderer trailRenderer = null;
    [SerializeField] private ParticleSystem particleSystem = null;
    public void Throw(float distance, Vector2 direction, float speed)
    {
        SetAngle(direction);
        StartCoroutine(MoveCoroutine(distance, direction, speed));
    }

    private IEnumerator MoveCoroutine(float distance, Vector2 direction, float speed)
    {
        for (float curDist = 0f; curDist < distance; curDist += speed * Time.deltaTime)
        {
            transform.position += (Vector3)direction * speed * Time.deltaTime;
            yield return new WaitForEndOfFrame();
        }
        FadeOut();
    }

    private void SetAngle(Vector2 direction)
    {
        Vector2 dir4 = direction.Get4Direction();
        float angle = 0;

        if (dir4.x > 0 && dir4.y == 0)
            angle = 180;
        if (dir4.x < 0 && dir4.y == 0)
            angle = 0;
        if (dir4.y > 0 && dir4.x == 0)
            angle = 270;
        if (dir4.y < 0 && dir4.x == 0)
            angle = 90;

        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        Unicorn unicorn = collision.GetComponent<Unicorn>();

       if (unicorn)
       {
           unicorn.Stun();
       }
        if (collision.GetComponent<Light2D>())
            return;
       if (!collision.CompareTag("Player"))
            Explode();
    }

    private void Explode()
    {
        particleSystem.transform.parent = null;
        particleSystem.Play();
        Destroy(particleSystem.gameObject, 2f);
        Destroy(gameObject);
    }

    private void FadeOut()
    {
        Destroy(gameObject);
    }

    private void OnDestroy()
    {
        StopCoroutine("MoveCoroutine");
    }
}
