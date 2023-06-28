using UnityEngine;

[RequireComponent(typeof(GhostMovement))]
public class Ghost : MonoBehaviour
{
    private GhostMovementView _movement;
    private GhostAI _ghostAI;

    private void Awake()
    {
        _movement = GetComponent<GhostMovement>().Init();
    }

    public void Inject(GhostAI ghostAI)
    {
        _ghostAI = ghostAI;
    }

    private void FixedUpdate()
    {
        _ghostAI.Update();
        _movement.Move(Converter.Vector3ToVector2InXZ(_ghostAI.WhereToMove()));
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            EventBus.Instance.Invoke<GameEnd>(new GameEnd(true));
        }
    }
}
