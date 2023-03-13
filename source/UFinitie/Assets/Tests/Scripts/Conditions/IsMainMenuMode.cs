using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Menu/Condition/Main Menu")]
public class IsMainMenuMode : Condition
{
    public override bool Value => MenuModeService.Mode == MenuMode.MainMenu;
}
