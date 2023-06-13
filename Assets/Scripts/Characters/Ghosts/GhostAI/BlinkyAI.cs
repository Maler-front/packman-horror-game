using UnityEngine;

public class BlinkyAI : GhostAI
{
    public BlinkyAI(Transform transform): base(transform) { }

    public override Vector3 WhereToMove()
    {
        return _target.position;
    }
}
