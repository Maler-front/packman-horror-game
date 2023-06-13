using UnityEngine;

public abstract class GhostAI
{
    protected static Transform _target;
    protected Transform _transform;

    public GhostAI(Transform transform)
    {
        _transform = transform;
    }

    public static void Init(Transform target) => _target = target;
    public abstract Vector3 WhereToMove();
}
