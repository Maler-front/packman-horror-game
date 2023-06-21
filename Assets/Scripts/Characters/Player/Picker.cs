using UnityEngine;

public class Picker : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.TryGetComponent<IPickableUp>(out IPickableUp item))
        {
            item.PickUp(this);
        }
    }
}
