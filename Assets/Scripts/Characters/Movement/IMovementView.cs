using UnityEngine;

namespace Movement
{
    public interface IMovementView : IView
    {
        public void Move(Vector2 direction);
    }
}
