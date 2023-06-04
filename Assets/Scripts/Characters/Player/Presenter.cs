namespace PlayerMVP
{
    public class Presenter : IPresenter
    {
        private PlayerView _view;
        private Model _model;

        public Presenter(PlayerView view, Model model)
        {
            _view = view;
            _model = model;

            _model.Init(this);
            _view.Init(this);
        }

        public void Activate()
        {
            throw new System.NotImplementedException();
        }

        public void Deactivate()
        {
            throw new System.NotImplementedException();
        }
    }
}