using UnityEngine;
using Movement.PlayerMovement;
using UnityEngine.InputSystem;

[RequireComponent(typeof(PlayerMovement), typeof(PlayerLook))]
public class Player : MonoBehaviour
{
    private PlayerMovementView _movement;
    private InputAction _movementAction;
    private PlayerLook _look;
    private InputAction _lookAction;

    private void Awake()
    {
        _look = GetComponent<PlayerLook>();

        PlayerMovement movementStarter = GetComponent<PlayerMovement>();
        _movement = movementStarter.Init();

        PlayerControls playerControls = new();
        _movementAction = playerControls.Player.Move;
        _lookAction = playerControls.Player.Look;
        _movementAction.Enable();
        _lookAction.Enable();
    }

    private void FixedUpdate()
    {
        PerformingActions.DoVector2Action(_movementAction, (direction) => _movement.Move(direction));
        PerformingActions.DoVector2Action(_lookAction, (direction) => _look.ChangeLook(direction));
    }
}
