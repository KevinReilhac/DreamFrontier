﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimMovements : MonoBehaviour
{
    [SerializeField] private Animator animator = null;

    private Vector2 _velocity = Vector2.zero;
    private Vector2 _lastPos = Vector2.zero;


    private void Update()
    {
        UpdateVelocity();
        UpdateAnimator();
    }

    private void UpdateAnimator()
    {
        animator.SetBool("Idle", _velocity.magnitude < 0.3f);
        if (_velocity.magnitude > 0.3f)
        {
            animator.SetFloat("SpeedX", Mathf.Clamp(_velocity.x, -1, 1));
            animator.SetFloat("SpeedY", Mathf.Clamp(_velocity.y, -1, 1));
        }
    }

    private void UpdateVelocity()
    {
        _velocity = ((Vector2)transform.position - _lastPos) / Time.deltaTime;
        _lastPos = transform.position;
    }


}
