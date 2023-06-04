using UnityEngine;
using UnityEngine.InputSystem;
using PlayerMVP;

[RequireComponent(typeof(PlayerView), typeof(PlayerMovement))]
public class Player : MonoBehaviour
{
    [SerializeField] private float _speed;

    void Start()
    {
        Model model = new Model(_speed);
        PlayerView view = GetComponent<PlayerView>();

        new Presenter(view, model);

        PlayerMovement movementController = GetComponent<PlayerMovement>();
        InputAction moveActions = new PlayerControls().Player.Move;
        movementController.Init(model, moveActions);
    }
}
