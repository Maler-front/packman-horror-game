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

        public CharacterController CharacterController { get; private set; }

        public void Init(float speed, CharacterController characterController)
        {
            Speed = speed;
            CharacterController = characterController;
        }

        public Vector3 CalculateMoveDirection(Vector3 direction)
        {
            return Vector3.ClampMagnitude(direction * Speed, Speed);
        }

        public Action<float> SpeedChanged;
    }
}