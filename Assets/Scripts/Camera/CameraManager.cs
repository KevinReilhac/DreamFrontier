using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    [SerializeField] private Transform target = null;

    private void Start()
    {
        if (target == null)
            target = GameObject.FindObjectOfType<Player>()?.transform;
    }

    private void Update()
    {
        UpdateCameraPosition();
    }

    private void UpdateCameraPosition()
    {
        transform.position = new Vector3(target.position.x, target.position.y, transform.position.z);
    }
}
