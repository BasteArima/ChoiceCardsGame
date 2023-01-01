using UnityEngine;
using UniRx;
using UnityEngine.Events;

[CreateAssetMenu(menuName = "Data/SessionData")]
public class SessionData : ScriptableObject
{
    public enum States
    {
        None,
        AppStart,
        MainMenu,
        InitializeGame,
        Game,
        EndGame
    }
    
    public UnityEvent Restarted;
    public UnityEvent GameOver;
    public UnityEvent Restored;
    
    public ReactiveProperty<States> State = new ReactiveProperty<States>(States.None);
    public ReactiveProperty<MenuName> CurrentTab = new ReactiveProperty<MenuName>();

    public void Restart()
    {
        Restarted?.Invoke();
    }

    public void StartGameOver()
    {
        GameOver?.Invoke();
    }

    public void Restore()
    {
        Restored?.Invoke();
    }
}
