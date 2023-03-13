using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Menu/Action/Open Main Menu")]
public class OpenMainMenuAction : MenuStateActionBase<MainMenuView>
{
    public override void OnEnter()
    {
        base.OnEnter();
        RegisterButtonClick(_view.GameButton, MenuMode.NewGame);
        RegisterButtonClick(_view.SettingsButton, MenuMode.Settings);
        RegisterButtonClick(_view.ExitButton, MenuMode.Exit);
    }

    public override void OnExit()
    {
        _view.GameButton.onClick.RemoveAllListeners();
        _view.SettingsButton.onClick.RemoveAllListeners();
        _view.ExitButton.onClick.RemoveAllListeners();
        base.OnExit();
    }
}
