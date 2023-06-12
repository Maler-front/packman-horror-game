using System.Collections;
using UnityEngine;

namespace Movement.PlayerMovement
{
    public class PlayerMovementModel : IMovementModel
    {
        private PlayerMovementPresenter _presenter;

        private float _walkSpeed = 5f;
        private float _runSpeed = 10f;
        private float _maxStamina = 100f;
        private float _staminaDecrement = 5f;
        private float _staminaIncrement = 2.5f;

        public float _stamina = 100f;
        private bool _isRunning = false;
        private bool _canRun = true;

        public CharacterController CharacterController { get; private set; }

        public float CurrentSpeed
        {
            get
            {
                if (_isRunning)
                    return _runSpeed;

                return _walkSpeed;
            }
        }

        public bool IsRunning
        {
            get
            {
                return _isRunning;
            }
            set
            {
                _isRunning = _canRun && value;
            }
        }

        public void Init(PlayerMovementPresenter presenter, CharacterController characterController, float walkSpeed = 5f, float runSpeed = 10f)
        {
            _presenter = presenter;
            _walkSpeed = walkSpeed;
            _runSpeed = runSpeed;
            CharacterController = characterController;

            _presenter.StartCoroutine(StaminaRestoration());
        }

        public Vector3 CalculateMoveDirection(Vector3 direction)
        {
            float speed = _isRunning ? _runSpeed : _walkSpeed;

            return Vector3.ClampMagnitude(direction * speed, speed);
        }

        private IEnumerator StaminaRestoration()
        {
            while (true)
            {
                yield return null;

                if (_isRunning)
                {
                    _stamina = Mathf.Clamp(_stamina - _staminaDecrement * Time.fixedDeltaTime, 0f, _maxStamina);

                    if (_stamina == 0f)
                    {
                        _canRun = false;
                        _isRunning = false;
                    }
                }
                else
                {
                    _stamina = Mathf.Clamp(_stamina + _staminaIncrement * Time.fixedDeltaTime, 0f, _maxStamina);

                    if (_stamina == _maxStamina)
                        _canRun = true;
                }

                Debug.Log($"stamina : {_stamina}");
            }
        }
    }
}