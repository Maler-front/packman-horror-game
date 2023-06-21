using UnityEngine;

public class Point : MonoBehaviour, IPickableUp
{
    public void PickUp(object caller)
    {
        EventBus.Instance.Invoke<PointPickedUp>(new PointPickedUp());
        Destroy(gameObject);
    }
}
