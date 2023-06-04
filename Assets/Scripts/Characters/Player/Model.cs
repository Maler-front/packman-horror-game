using UnityEngine;

namespace PlayerMVP
{
    public class Model : IMovementModel
    {
        private Presenter _presenter;

        public float Speed { get; private set; }

        public Model(float speed)
        {
            speed = Mathf.Clamp(speed, 0, float.MaxValue);
            Speed = speed;
        }

        public void Init(Presenter presenter)
        {
            if (_presenter != null)
                return;

            _presenter = presenter;
        }

        public float GetSpeed()
        {
            return Speed;
        }
    }
}