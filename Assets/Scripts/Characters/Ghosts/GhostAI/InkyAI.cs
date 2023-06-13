using UnityEngine;

public class InkyAI : GhostAI
{
    private float _distance = 20f;

    public InkyAI(Transform transform) : base(transform) { }

    public override Vector3 WhereToMove()
    {
        _transform.LookAt(_target);
        return _target.position + _target.forward * _distance;
    }
}
