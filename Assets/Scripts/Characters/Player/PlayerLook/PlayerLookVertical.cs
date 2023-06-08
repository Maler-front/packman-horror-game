using UnityEngine;

public class PlayerLookVertical : MonoBehaviour
{
    [SerializeField] private GameObject _target;

    [SerializeField] private float _sensivity = 10f;
    [SerializeField][Range(-90f, 90f)] private float _minAngle = -45f;
    [SerializeField][Range(-90f, 90f)] private float _maxAngle = 45f;

    private float _currentAngle;

    private void Awake()
    {
        if (_target == null)
            _target = gameObject;
    }

    public void Rotate(float angle)
    {
        angle *= _sensivity * Time.fixedDeltaTime;

        float newAngle = _currentAngle + angle;
        newAngle = Mathf.Clamp(newAngle, _minAngle, _maxAngle);
        float addAngle = newAngle - _currentAngle;

        _currentAngle += addAngle;
        _target.transform.Rotate(addAngle, 0f, 0f);
    }
}
