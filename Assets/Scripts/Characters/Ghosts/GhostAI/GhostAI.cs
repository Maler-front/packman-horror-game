using UnityEngine;

public abstract class GhostAI
{
    protected static Transform _target;
    protected Transform _transform;
    protected Vector3 _homePoint;

    private const float _minHideDistance = 15f;

    private static State _state;

    protected const float _timeBetweenChillAndHunt = 15f;
    protected static float _chillTimeLeft;

    public void Init(Transform transform, Vector3 homePoint)
    {
        _transform = transform;
        _homePoint = homePoint;

        EventBus.Instance.Subscribe<CherryPickedUp>((signal) => ChangeState(State.Hide));
    }

    public static void SetTarget(Transform target) => _target = target;
    public static void ChangeState(State newState)
    {
        if (_state == State.Hide)
        {
            _chillTimeLeft = _timeBetweenChillAndHunt;
        }
        _state = newState;
    }

    public Vector3 WhereToMove()
    {
        switch (_state)
        {
            case State.Hunt:
                {
                    return Hunt();
                }
            case State.Chill:
                {
                    return Chill();
                }
            case State.Hide:
                {
                    return Hide();
                }
        }
        Debug.LogError("State error in GhostAI");
        return Vector3.zero;
    }

    private Vector3 Chill()
    {
        return _homePoint;
    }

    private Vector3 Hide()
    {
        if (Vector3.Distance(_target.position, _transform.position) >= _minHideDistance)
            return _homePoint;
        else
        {
            return (_transform.position - _target.position).normalized * _minHideDistance;
        }
    }

    protected abstract Vector3 Hunt();

    public void Update()
    {
        if(_state == State.Chill)
        {
            _chillTimeLeft -= Time.fixedDeltaTime;
            if(_chillTimeLeft <= 0f)
            {
                ChangeState(State.Hunt);
            }
        }
    }

    public enum State
    {
        Hunt,
        Chill,
        Hide
    }
}
