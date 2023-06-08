using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLookHorizontal : MonoBehaviour
{
    [SerializeField] private GameObject _target;

    [SerializeField] private float _sensivity = 10f;

    private void Awake()
    {
        if (_target == null)
            _target = gameObject;
    }

    public void Rotate(float angle)
    {
        float newAngle = angle * _sensivity * Time.fixedDeltaTime;

        _target.transform.Rotate(0f, newAngle, 0f);
    }
}
