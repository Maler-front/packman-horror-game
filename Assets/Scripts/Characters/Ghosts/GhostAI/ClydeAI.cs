using UnityEngine;

public class ClydeAI : GhostAI
{
    private const float _minDistance = 10f;

    protected override Vector3 Hunt()
    {
        if (Vector3.Distance(_transform.position, _target.position) <= _minDistance)
        {
            return Vector3.zero; //Temporarily
        }

        return _target.position;
    }
}
