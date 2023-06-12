using Movement;
using UnityEngine;
using UnityEngine.AI;

public class GhostMovementModel : IMovementModel
{
    private GhostMovementPresenter _presenter;
    public NavMeshAgent NavMeshAgent { get; private set; }

    public void Init(GhostMovementPresenter presenter, NavMeshAgent navMeshAgent, float speed)
    {
        _presenter = presenter;
        NavMeshAgent = navMeshAgent;
        NavMeshAgent.speed = speed;
    }
}
