using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class GhostMovement : MonoBehaviour
{
    [SerializeField] private float _speed;

    public GhostMovementView Init()
    {
        if (!TryGetComponent<GhostMovementView>(out GhostMovementView view))
            view = gameObject.AddComponent<GhostMovementView>();

        GhostMovementModel model = new();
        GhostMovementPresenter presenter = new GhostMovementPresenter(view, model);

        NavMeshAgent navMeshAgent = GetComponent<NavMeshAgent>();

        view.Init(presenter);
        model.Init(presenter: presenter, navMeshAgent: navMeshAgent, speed: _speed);

        enabled = false;
        return view;
    }
}
