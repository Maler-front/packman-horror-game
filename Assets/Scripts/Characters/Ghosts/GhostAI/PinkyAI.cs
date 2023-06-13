using UnityEngine;

public class PinkyAI : GhostAI
{
    private float _distance = 20f;
    private float _minDistance = 30f;

    public PinkyAI(Transform transform) : base(transform) { }

    public override Vector3 WhereToMove()
    {
        if(Vector3.Distance(_target.position, _transform.position) <= _minDistance)
        {
            return _target.position;
        }

        return _target.position + _target.forward * _distance;
    }
}
