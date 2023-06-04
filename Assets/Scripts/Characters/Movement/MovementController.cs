using UnityEngine;

public abstract class MovementController : MonoBehaviour
{
    protected IMovementModel _model;

    public bool InitModel(IMovementModel model)
    {
        if (_model != null)
            return false;

        _model = model;

        return true;
    }

    protected abstract void Move(Vector2 direction);
}
