using UnityEngine;

namespace PlayerMVP 
{
    public class PlayerView : MonoBehaviour, IView
    {
        private Presenter _presenter;

        public void Init(Presenter presenter)
        {
            if (_presenter != null)
                return;

            _presenter = presenter;
        }
    }
}