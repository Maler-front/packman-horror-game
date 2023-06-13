public static class GhostAIInjector
{
    public static void SetGhostAI(Ghost target, Ghosts type)
    {
        GhostAI AI;

        switch (type)
        {
            case Ghosts.Blinky:
                {
                    AI = new BlinkyAI();
                    break;
                }
            case Ghosts.Pinky:
                {
                    AI = new PinkyAI();
                    break;
                }
            case Ghosts.Inky:
                {
                    AI = new InkyAI();
                    break;
                }
            case Ghosts.Clyde:
                {
                    AI = new ClydeAI();
                    break;
                }
            default:
                {
                    AI = new BlinkyAI();
                    break;
                }
        }

        AI.Init(target.transform, target.transform.position);
        target.Inject(AI);
    }

    public enum Ghosts
    {
        Blinky,
        Pinky,
        Inky,
        Clyde
    }
}
