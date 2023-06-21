using UnityEngine;
using UnityEngine.UI;

public class PointCounter : MonoBehaviour
{
    [SerializeField] private Text _scoreText;
    [SerializeField] private int _pointsToWin = 10;

    private int _currentScore = 0;

    private void Start()
    {
        _scoreText.text = (_pointsToWin - _currentScore).ToString();
        EventBus.Instance.Subscribe<PointPickedUp>((signal) => IncreaseScore(1));
    }

    private void IncreaseScore(int score)
    {
        _currentScore += score;

        /*if (_currentScore <= _pointsToWin)
            EventBus.Instance.Invoke<GameWin>(new GameWin());*/

        _scoreText.text = (_pointsToWin - _currentScore).ToString();
    }
}
