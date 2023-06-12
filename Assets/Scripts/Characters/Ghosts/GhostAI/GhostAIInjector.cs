public static class GhostAIInjector
{
    public static void SetGhostAI(Ghost target, Ghosts type)
    {
        switch (type)
        {
            case Ghosts.Blinky:
                {
                    target.Init(new BlinkyAI());
                    break;
                }
            case Ghosts.Pinky:
                {
                    throw new System.NotImplementedException();
                }
        }
    }

    public enum Ghosts
    {
        Blinky,
        Pinky
    }
}
