using UnityEngine;

namespace Movement.PlayerMovement
{
    [RequireComponent(typeof(Rigidbody))]
    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField] [Range(0, 50f)] private float _speed = -1f;

        public PlayerMovementView Init()
        {
            if (!TryGetComponent<PlayerMovementView>(out PlayerMovementView view))
                view = gameObject.AddComponent<PlayerMovementView>();

            PlayerMovementModel model = new();
            PlayerMovementPresenter presenter = new PlayerMovementPresenter(view, model);

            view.Init(presenter);
            model.Init(speed: _speed, characterController: GetComponent<CharacterController>());

            enabled = false;
            return view;
        }
    }
}