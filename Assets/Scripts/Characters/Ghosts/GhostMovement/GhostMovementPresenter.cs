using Movement;
using UnityEngine;
using UnityEngine.AI;

public class GhostMovementPresenter : IMovementPresenter
{
    private GhostMovementView _view;
    private GhostMovementModel _model;

    public GhostMovementPresenter(GhostMovementView view, GhostMovementModel model)
    {
        _view = view;
        _model = model;
        Activate();
    }

    public NavMeshAgent GetNavMeshAgent()
    {
        return _model.NavMeshAgent;
    }

    public void Activate()
    {
        return;
    }

    public void Deactivate()
    {
        throw new System.NotImplementedException();
    }
}
