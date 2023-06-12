using UnityEngine;

public class GhostMovement : MonoBehaviour
{
    [SerializeField] private float _speed;

    public GhostMovementView Init()
    {
        if (!TryGetComponent<GhostMovementView>(out GhostMovementView view))
            view = gameObject.AddComponent<GhostMovementView>();

        GhostMovementModel model = new();
        GhostMovementPresenter presenter = new GhostMovementPresenter(view, model);

        view.Init(presenter);
        model.Init(presenter: presenter, speed: _speed);

        enabled = false;
        return view;
    }
}
