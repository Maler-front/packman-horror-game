using UnityEngine;
using Movement;

public class GhostMovementView : MonoBehaviour, IMovementView
{
    private GhostMovementPresenter _presenter;

    public void Init(GhostMovementPresenter presenter)
    {
        _presenter = presenter;
    }

    public void Move(Vector2 direction)
    {
        _presenter.GetNavMeshAgent().destination = new Vector3(direction.x, transform.position.y, direction.y);
    }
}
