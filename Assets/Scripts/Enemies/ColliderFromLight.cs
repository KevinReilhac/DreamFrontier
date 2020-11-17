using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;
using NaughtyAttributes;
using System.Linq;

public class ColliderFromLight : MonoBehaviour
{
    [SerializeField] private PolygonCollider2D polygoneCollider = null;
    [SerializeField] private Light2D polygoneLight = null;

    private void Start()
    {
        UpdateCollider();
    }

    private void Update()
    {
        polygoneCollider.enabled = polygoneLight.enabled;
    }

    [Button("Update")]
    private void UpdateCollider()
    {
        polygoneCollider.points = (from v3 in polygoneLight.shapePath select (Vector2)v3).ToArray<Vector2>();
    }
}
