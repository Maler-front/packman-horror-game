using UnityEngine;

public class Cherry : MonoBehaviour, IPickableUp
{
    public void PickUp(object caller)
    {
        EventBus.Instance.Invoke<CherryPickedUp>(new CherryPickedUp());
        Destroy(gameObject);
    }
}
