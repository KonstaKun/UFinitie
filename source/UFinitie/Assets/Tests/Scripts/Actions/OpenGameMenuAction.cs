using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Menu/Action/Open Game Menu")]
public class OpenGameMenuAction : MenuStateActionBase<GameMenuView>
{
    public override void OnEnter()
    {
        base.OnEnter();
        RegisterButtonClick(_view.ReturnButton, MenuMode.MainMenu);
    }

    public override void OnExit()
    { 
        _view.ReturnButton.onClick.RemoveAllListeners();
        base.OnExit();
    }
}
