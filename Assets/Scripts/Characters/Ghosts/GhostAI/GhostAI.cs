using UnityEngine;

public abstract class GhostAI
{
    protected static Transform _target;

    public static void Init(Transform target) => _target = target;
    public abstract Vector3 WhereToMove();
}
