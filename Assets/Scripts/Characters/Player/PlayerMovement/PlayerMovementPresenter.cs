using UnityEngine;


namespace Movement.PlayerMovement
{
    public class PlayerMovementPresenter : IMovementPresenter
    {
        private PlayerMovementView _view;
        private PlayerMovementModel _model;

        public PlayerMovementPresenter(PlayerMovementView view, PlayerMovementModel model)
        {
            _view = view;
            _model = model;
            Activate();
        }

        public Vector3 CalculateMoveDirection(Vector3 direction)
        {
            return _model.CalculateMoveDirection(direction);
        }

        public CharacterController GetCharacterController()
        {
            return _model.CharacterController;
        }

        public void Activate()
        {
            return;
        }

        public void Deactivate()
        {
            throw new System.NotImplementedException();
        }
    }
}