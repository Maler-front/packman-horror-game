using System;
using UnityEngine;
using UnityEngine.InputSystem;

public static class PerformingActions
{
    public static bool DoVector2Action(InputAction inputAction, Action<Vector2> doAction)
    {
        if (inputAction.ReadValue<Vector2>() == null)
        {
            Debug.LogError("An InputAction was passed to DoVector2Action that does not have Vector2");
            return false;
        }

        if (inputAction.ReadValue<Vector2>() != Vector2.zero)
            doAction?.Invoke(inputAction.ReadValue<Vector2>());

        return true;
    }
}
