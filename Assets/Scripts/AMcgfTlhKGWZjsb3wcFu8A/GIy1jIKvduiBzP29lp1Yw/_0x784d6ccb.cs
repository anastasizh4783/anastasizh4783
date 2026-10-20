using UnityEngine;

public class _0x784d6ccb : MonoBehaviour
{
    public bool IsLevelSelectorEnabled;
    public bool IsCheckScoreEnabled;
    public bool IsTutorialEnabled;
    public bool IsOnlyWinGameEndEnabled;
    public bool IsTimerEnabled;
    public bool IsLevelIncrementOnWin;
    public bool IsBestScoreEnabled;
    public bool IsSkipSplashEnabled;
    public bool IsStoryEnabled;
    private void _0x382a6bdb()
    {
    }

    public static _0x784d6ccb Instance;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this.gameObject.GetComponent<_0x784d6ccb>();
            DontDestroyOnLoad(this.gameObject);
            this._0xcf47f438();
        }
        else
        {
            this._0x382a6bdb();
            Destroy(this.gameObject);
        }
    }

    private void _0xcf47f438()
    {
        {
#if !B_LOGS
        {
            Debug.unityLogger.logEnabled = false;
            Application.SetStackTraceLogType(LogType.Assert, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Exception, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Warning, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Error, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Log, StackTraceLogType.None);
        }
#endif
        }

        QualitySettings.vSyncCount = 1;
        Application.runInBackground = true;
    //Application.targetFrameRate = 60;
    // Time.fixedDeltaTime = 0.03f; // USE CUSTOM PHYSICS TIME FOR OPTIMIZATION IF NEEDED
    // Add this once at startup to silence the specific assertion
    }
}