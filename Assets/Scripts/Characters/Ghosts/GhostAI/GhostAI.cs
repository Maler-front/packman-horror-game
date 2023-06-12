using UnityEngine;

public abstract class GhostAI
{
    protected Transform _target;

    public void Init(Transform target)
    {
        _target = target;
        return;
    }

    public abstract Vector3 WhereToMove();
}
