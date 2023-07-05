using UnityEngine;

public class GameEndScreenShower : MonoBehaviour
{
    [SerializeField] private GameObject _loseScreen;
    [SerializeField] private GameObject _winScreen;

    private void Start()
    {
        Time.timeScale = 1;

        EventBus.Instance.Subscribe<GameEnd>(ShowGameEndScreen);
    }

    private void ShowGameEndScreen(GameEnd signal)
    {

        bool isGameLost = signal._isGameLost;
        GameObject showScreen = isGameLost ? _loseScreen : _winScreen;
        showScreen.SetActive(true);

        Time.timeScale = 0;

        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    private void OnDisable()
    {
        EventBus.Instance.Unsubscribe<GameEnd>(ShowGameEndScreen);
    }
}
