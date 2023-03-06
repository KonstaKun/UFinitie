using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "UFinitie/State Action/Debug")]
public class DebugAction : StateAction
{
    public override void OnEnter()
    {
        Debug.Log($"OnEnter");
    }

    public override void OnExit()
    {
        Debug.Log($"OnExit");
    }
}
