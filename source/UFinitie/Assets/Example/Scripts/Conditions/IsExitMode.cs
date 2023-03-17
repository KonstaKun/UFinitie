using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Menu/Condition/Exit")]
public class IsExitMode : Condition
{
    public override bool Value => MenuModeService.Mode == MenuMode.Exit;
}
