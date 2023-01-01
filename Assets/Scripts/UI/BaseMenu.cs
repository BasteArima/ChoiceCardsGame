using UnityEngine;
using UnityEngine.Events;

public class BaseMenu : MonoBehaviour
{
    private UnityEvent DoWhenPressEscape { get; }

    [SerializeField] protected MenuName _name;

    protected AppData _data;
    private InputController _inputController;

    public MenuName Name => _name;
    public bool State { get; private set; }

    public virtual void Initialize(AppData data, InputController inputController)
    {
        _data = data;
        _inputController = inputController;
        _inputController.EscapePressed.AddListener(DoTargetAction);
    }
    
    private void DoTargetAction()
    {
        DoWhenPressEscape.Invoke();
    }

    public virtual void SetState(bool state)
    {
        State = state;
    }
}