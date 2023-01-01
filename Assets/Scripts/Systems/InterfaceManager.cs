using System.Linq;
using TMPro;
using UnityEngine;

public enum MenuName
{
    None = 0,
    MainMenu = 1,
    SettingsMenu = 2,
    AboutMenu = 3,
    PauseMenu = 4
}

public class InterfaceManager : BaseMonoSystem
{
    [SerializeField] private BaseMenu[] _menus;

    [SerializeField] private InputController _inputController;
    [SerializeField] private TMP_Text _versionText;

    public override void Initialize(AppData data)
    {
        base.Initialize(data);

        InitializeMenus();
        Toggle(MenuName.MainMenu);
        _versionText.text = Application.version;
    }

    private void InitializeMenus()
    {
        foreach (var baseMenu in _menus)
            baseMenu.Initialize(data, _inputController);
    }

    private void Toggle(MenuName name)
    {
        foreach (var baseMenu in _menus)
        {
            var state = baseMenu.Name == name;
            baseMenu.gameObject.SetActive(state);
            baseMenu.SetState(state);
        }
    }

    public void ToggleAdditional(MenuName name, bool state)
    {
        var baseMenu = _menus.SingleOrDefault(m => m.Name == name);
        if (baseMenu == null) return;
        baseMenu.gameObject.SetActive(state);
        baseMenu.SetState(state);
    }
}