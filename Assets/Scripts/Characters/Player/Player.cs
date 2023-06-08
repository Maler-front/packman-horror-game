using UnityEngine;
using Movement;
using Movement.PlayerMovement;
using UnityEngine.InputSystem;

[RequireComponent(typeof(PlayerMovement), typeof(PlayerLook))]
public class Player : MonoBehaviour
{
    private PlayerMovementView _movement;
    private InputAction _movementAction;
    private PlayerLook _look;

    private void Awake()
    {
        _look = GetComponent<PlayerLook>();
        _look.Init(Mouse.current);

        PlayerMovement movementStarter = GetComponent<PlayerMovement>();
        _movement = movementStarter.Init();

        PlayerControls playerControls = new();
        _movementAction = playerControls.Player.Move;
        _movementAction.Enable();
    }

    private void FixedUpdate()
    {
        if(_movementAction.ReadValue<Vector2>() != Vector2.zero)
            _movement.Move(_movementAction.ReadValue<Vector2>());

        _look.Look();
    }
}
