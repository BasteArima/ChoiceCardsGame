using UnityEngine;

[RequireComponent(typeof(SystemInitializer))]
public class AppStartup : MonoBehaviour
{
    [SerializeField] private AppData _data;

    private void Awake()
    {
        Application.targetFrameRate = 60;
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
        Time.timeScale = 1;
        
        _data.sessionData.State.Value = SessionData.States.AppStart;
        this.GetComponent<SystemInitializer>().InitializeSystems(_data);
    }
}
