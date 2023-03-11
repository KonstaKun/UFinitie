using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "UFinitie/Transition Condition/True")]
public class TrueCondition : Condition
{
    public override bool Value => true;
}
