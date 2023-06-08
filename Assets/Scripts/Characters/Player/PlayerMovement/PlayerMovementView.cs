using UnityEngine;

namespace Movement.PlayerMovement
{
    public class PlayerMovementView : MonoBehaviour, IMovementView
    {
        private PlayerMovementPresenter _presenter;

        public void Init(PlayerMovementPresenter presenter)
        {
            if(presenter == null)
            {
                Debug.LogError("The Presenter in the PlayerMovementView class on the {name} object is null");
                return;
            }
            _presenter = presenter;
        }

        public void Move(Vector2 direction)
        {
            direction = -1 * direction * _presenter.GetSpeed();

            Rigidbody rigidbody = _presenter.GetRigidbody();
            rigidbody.AddRelativeForce(new Vector3(direction.x, 0f, direction.y), ForceMode.Impulse);
        }
    }
}