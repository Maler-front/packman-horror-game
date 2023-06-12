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

    private void FixedUpdate()
    {
        _movement.Move(Converter.Vector3ToVector2InXZ(_ghostAI.WhereToMove()));
    }
}
