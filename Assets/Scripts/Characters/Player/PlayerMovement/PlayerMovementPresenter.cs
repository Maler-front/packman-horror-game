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

        public float GetSpeed()
        {
            return _model.Speed;
        }

        public Rigidbody GetRigidbody()
        {
            return _model.Rigidbody;
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