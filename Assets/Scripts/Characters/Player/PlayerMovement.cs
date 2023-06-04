using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMovement : MovementController
{
    private InputAction _move;
    private Rigidbody _rigidbody;

    public bool Init(IMovementModel model, InputAction move)
    {
        _rigidbody = GetComponent<Rigidbody>();

        if (move == null)
            return false;

        _move = move;
        
        return InitModel(model);
    }

    private void FixedUpdate()
    {
        Move(_move.ReadValue<Vector2>());
    }

    protected override void Move(Vector2 direction)
    {
        direction = direction * _model.GetSpeed() * Time.fixedDeltaTime;

        Debug.Log(direction);
        _rigidbody.MovePosition(new Vector3(direction.x, transform.position.y, direction.y));
    }
}
