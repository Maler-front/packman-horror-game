using UnityEngine;

public class Cherry : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            EventBus.Instance.Invoke<CherryPickedUp>(new CherryPickedUp());
            Destroy(gameObject);
        }
    }
}
