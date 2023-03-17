using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Menu/Condition/New Game")]
public class IsNewGameMode : Condition
{
    public override bool Value => MenuModeService.Mode == MenuMode.NewGame;
}
