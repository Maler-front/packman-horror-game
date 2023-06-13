using UnityEngine;

public class BlinkyAI : GhostAI
{
    protected override Vector3 Hunt()
    {
        return _target.position;
    }
}
