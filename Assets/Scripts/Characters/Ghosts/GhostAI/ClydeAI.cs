using UnityEngine;

public class ClydeAI : GhostAI
{
    private float _minDistance = 10f;

    public ClydeAI(Transform transform) : base(transform) { }

    public override Vector3 WhereToMove()
    {
        if(Vector3.Distance(_transform.position, _target.position) <= _minDistance)
        {
            return Vector3.zero; //Temporarily
        }

        return _target.position;
    }
}
