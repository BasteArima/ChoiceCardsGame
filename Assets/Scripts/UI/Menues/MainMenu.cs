using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : BaseMenu
{
    [SerializeField] private Button _hostButton;
    [SerializeField] private Button _findGameButton;
    [SerializeField] private Button _aboutButton;
    [SerializeField] private Button _settingsButton;
    [SerializeField] private Button _exitButton;
    [SerializeField] private TMP_InputField _findGameCodeInput;

    private void Awake()
    {
        _hostButton.onClick.AddListener(OnHostButton);
        _findGameButton.onClick.AddListener(OnFindGameButton);
        _aboutButton.onClick.AddListener(OnAboutButton);
        _settingsButton.onClick.AddListener(OnSettingsButton);
        _exitButton.onClick.AddListener(OnExitGameButton);
        _findGameCodeInput.onValueChanged.AddListener(OnFindGameCodeValueChanged);
        _findGameCodeInput.onValueChanged.Invoke("");
    }

    private void OnHostButton()
    {

    }

    private void OnFindGameButton()
    {
    }

    private void OnAboutButton()
    {
        _data.sessionData.CurrentTab.Value = MenuName.AboutMenu;
    }

    private void OnSettingsButton()
    {
        _data.sessionData.CurrentTab.Value = MenuName.SettingsMenu;
    }

    private void OnExitGameButton()
    {
        Application.Quit();
    }

    private void OnFindGameCodeValueChanged(string value)
    {
        if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value) || value.Length < 4)
            _findGameButton.interactable = false;
        else
            _findGameButton.interactable = true;
    }
}