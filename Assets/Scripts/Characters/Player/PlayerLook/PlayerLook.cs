using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerLook : MonoBehaviour
{
    [SerializeField] private PlayerLookHorizontal _lookHorizontal;
    [SerializeField] private PlayerLookVertical _lookVertical;

    private Mouse _mouse;
    private Vector2 _mousePositionTemp;

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
    }

    public void Init(Mouse mouse)
    {
        if(mouse == null)
        {
            Debug.LogError($"Null was passed to the PlayerLook class on the {name} object in Init");
            return;
        }

        _mouse = mouse;
    }

    public void Look()
    {
        Vector2 newPosition = _mouse.position.ReadValue();
        if (_mousePositionTemp == newPosition)
            return;

        Vector2 rotateAngles = newPosition - _mousePositionTemp;
        rotateAngles.y *= -1;
        _mousePositionTemp = newPosition;

        _lookHorizontal.Rotate(rotateAngles.x);
        _lookVertical.Rotate(rotateAngles.y);
    }
}
