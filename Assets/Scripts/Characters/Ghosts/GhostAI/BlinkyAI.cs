using UnityEngine;

public class BlinkyAI : GhostAI
{
    public override Vector3 WhereToMove()
    {
        return _target.position;
    }
}
