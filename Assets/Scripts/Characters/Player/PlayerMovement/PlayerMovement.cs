using UnityEngine;

namespace Movement.PlayerMovement
{
    [RequireComponent(typeof(Rigidbody))]
    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField] [Range(0, 50f)] private float _walkSpeed = 5f;
        [SerializeField] [Range(0, 100f)] private float _runSpeed = 10f;

        public PlayerMovementView Init()
        {
            if (!TryGetComponent<PlayerMovementView>(out PlayerMovementView view))
                view = gameObject.AddComponent<PlayerMovementView>();

            PlayerMovementModel model = new();
            PlayerMovementPresenter presenter = new PlayerMovementPresenter(view, model);

            view.Init(presenter);
            model.Init(presenter: presenter, walkSpeed: _walkSpeed, runSpeed: _runSpeed, characterController: GetComponent<CharacterController>());

            enabled = false;
            return view;
        }
    }
}