using UnityEngine;

public class GameEndScreenShower : MonoBehaviour
{
    [SerializeField] private GameObject _loseScreen;
    [SerializeField] private GameObject _winScreen;

    private void Start()
    {
        EventBus.Instance.Subscribe<GameEnd>((GameEnd) => ShowGameEndScreen(GameEnd._isGameLost));
    }

    private void ShowGameEndScreen(bool isGameLost)
    {
        GameObject showScreen = isGameLost ? _loseScreen : _winScreen;
        showScreen.SetActive(true);

        Time.timeScale = 0;

        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
