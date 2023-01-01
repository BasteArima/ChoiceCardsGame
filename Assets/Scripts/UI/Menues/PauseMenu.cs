using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : BaseMenu
{
    [SerializeField] private Button _continueButton;
    [SerializeField] private Button _exitButton;

    private void Awake()
    {
        _continueButton.onClick.AddListener(OnContinueButton);
        _exitButton.onClick.AddListener(OnExitToMenuButton);
    }

    private void OnContinueButton()
    {
    }

    private void OnRestartButton()
    {
    }

    private void OnExitToMenuButton()
    {
        _data.sessionData.State.Value = SessionData.States.EndGame;
    }
}