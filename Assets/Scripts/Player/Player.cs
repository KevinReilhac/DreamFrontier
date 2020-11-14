using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [Header("Gameplay")]
    [SerializeField] private float speed = 1f;

    private Rigidbody2D _rigidbody = null;
    private PlayerControls _controls = null;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        SetupControls();
    }

    private void SetupControls()
    {
        _controls = new PlayerControls();
        _controls.Enable();

        _controls.MainGameplay.Movements.performed += UpdateMove;
        _controls.MainGameplay.Movements.canceled += UpdateMove;

        _controls.MainGameplay.Interact.started += Interact;
    }

    private void UpdateMove(InputAction.CallbackContext context)
    {
        Vector2 value = context.ReadValue<Vector2>();

        _rigidbody.velocity = value * speed;
    }

    private void Interact(InputAction.CallbackContext context)
    {
        print("Test");
    }
}
