public static class AutoSplitterData
{
    public static float InGameTime = 0f;
    public static string Level = "Menu";
    public static int Checkpoint = 0;
    public static RunState State = RunState.NotRunning;
}

public enum RunState
{
    NotRunning,
    Running,
    Completed
}
