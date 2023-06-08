using System;
using UnityEngine;

namespace Movement.PlayerMovement
{
    public class PlayerMovementModel : IMovementModel
    {
        private float _speed = 5f;

        public float Speed
        {
            get
            {
                return _speed;
            }
            set
            {
                if (_speed < 0)
                {
                    return;
                }
                else
                {
                    _speed = value;
                }

                SpeedChanged?.Invoke(Speed);
            }
        }

        public Rigidbody Rigidbody { get; private set; }

        public void Init(float speed, Rigidbody rigidbody)
        {
            Speed = speed;
            Rigidbody = rigidbody;
        }

        public Action<float> SpeedChanged;
    }
}