using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [Header("Gameplay")]
    [SerializeField] private float speed = 1f;
    [SerializeField] private float interactionRange = 1f;

    private Rigidbody2D _rigidbody = null;
    private PlayerControls _controls = null;

    private Vector2 _currentdir = Vector2.zero;
    private IInteractable _targetInteractable = null;

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

    private void Update()
    {
        SearchInteractable();
    }
    
    private void SearchInteractable()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, _currentdir, interactionRange);
        IInteractable newInteractable = null;

        if (hit.collider != null)
            newInteractable = hit.collider.GetComponent<IInteractable>();
        if (newInteractable == null)
        {
            _targetInteractable?.StopHighlight();
        }
        else if (newInteractable != _targetInteractable)
        {
            newInteractable.StartHighlight();
            _targetInteractable?.StopHighlight();
        }

        _targetInteractable = newInteractable;
    }

    private void UpdateMove(InputAction.CallbackContext context)
    {
        Vector2 value = context.ReadValue<Vector2>().Get4Direction();

        if (value != Vector2.zero)
            _currentdir = value;
        _rigidbody.velocity = value * speed;
    }

    private void Interact(InputAction.CallbackContext context)
    {
        if (_targetInteractable == null)
            return;
        _targetInteractable.Interact();
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(transform.position, transform.position + (Vector3)_currentdir * interactionRange);
        //Gizmos.DrawWireSphere(transform.position, interactionRange);
    }
}
