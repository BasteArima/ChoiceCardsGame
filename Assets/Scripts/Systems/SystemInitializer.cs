using UnityEngine;

public class SystemInitializer : MonoBehaviour
{
    [SerializeField] private BaseMonoSystem[] _systems;

    public void InitializeSystems(AppData data)
    {
        foreach (var system in _systems)
            system.Initialize(data);
        
        data.sessionData.State.Value = SessionData.States.MainMenu;
    }
}
