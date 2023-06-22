using System;
using UnityEngine;
using UnityEngine.UI;

namespace Movement.PlayerMovement
{
    public class PlayerMovementView : MonoBehaviour, IMovementView
    {
        private PlayerMovementPresenter _presenter;

        private Slider _staminaSlider;

        public void Init(PlayerMovementPresenter presenter, Slider staminaSlider)
        {
            if(presenter == null)
            {
                Debug.LogError("The Presenter in the PlayerMovementView class on the {name} object is null");
                return;
            }
            _presenter = presenter;

            _staminaSlider = staminaSlider;
            _staminaSlider.value = 1;
        }

        public void Move(Vector2 direction)
        {
            Vector3 motion = _presenter.CalculateMoveDirection(new Vector3(direction.x, 0f, direction.y));

            _presenter.GetCharacterController().Move(transform.TransformDirection(motion) * Time.deltaTime);
        }

        public void ChangeMoveMode(bool running)
        {
            _presenter.ChangeMoveMode(running);
        }

        internal void ShowStamina(float stamina)
        {
            _staminaSlider.value = stamina;
        }
    }
}