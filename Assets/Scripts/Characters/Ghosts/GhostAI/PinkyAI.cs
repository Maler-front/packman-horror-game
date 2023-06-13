using UnityEngine;

public class PinkyAI : GhostAI
{
    private const float _distance = 20f;
    private const float _minDistance = 30f;

    protected override Vector3 Hunt()
    {
        if (Vector3.Distance(_target.position, _transform.position) <= _minDistance)
        {
            return _target.position;
        }

        return _target.position + _target.forward * _distance;
    }
}
