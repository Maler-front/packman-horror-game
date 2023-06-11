using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerLook : MonoBehaviour
{
    [SerializeField] private PlayerLookHorizontal _lookHorizontal;
    [SerializeField] private PlayerLookVertical _lookVertical;

    private void Awake()
    {
        if(_lookHorizontal == null)
        {
            Debug.LogError($"The Player Look class lacks a PlayerLookHorizontal on the {name} object");
            return;
        }

        if(_lookVertical == null)
        {
            Debug.LogError($"The Player Look class lacks a PlayerLookVertical on the {name} object");
            return;
        }

        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void ChangeLook(Vector2 direction)
    {
        _lookHorizontal.Rotate(direction.x);
        _lookVertical.Rotate(-direction.y);
    }
}
