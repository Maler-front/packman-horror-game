using UnityEngine;

public class InkyAI : GhostAI
{
    private const float _distance = 20f;

    protected override Vector3 Hunt()
    {
        _transform.LookAt(_target);
        return _target.position + _target.forward * _distance;
    }
}
