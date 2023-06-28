public class GameEnd : IEventBusSignal
{
    public bool _isGameLost;

    public GameEnd(bool isGameLost) => _isGameLost = isGameLost;
}
