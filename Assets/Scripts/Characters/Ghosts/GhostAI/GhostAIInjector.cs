public static class GhostAIInjector
{
    public static void SetGhostAI(Ghost target, Ghosts type)
    {
        switch (type)
        {
            case Ghosts.Blinky:
                {
                    target.Init(new BlinkyAI(target.transform));
                    break;
                }
            case Ghosts.Pinky:
                {
                    target.Init(new PinkyAI(target.transform));
                    break;
                }
        }
    }

    public enum Ghosts
    {
        Blinky,
        Pinky
    }
}
