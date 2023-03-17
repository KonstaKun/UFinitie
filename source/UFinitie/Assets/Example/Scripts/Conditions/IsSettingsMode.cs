using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Menu/Condition/Settings")]
public class IsSettingsMode : Condition
{
    public override bool Value => MenuModeService.Mode == MenuMode.Settings;
}
