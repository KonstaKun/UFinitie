using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "UFinitie/Transition Condition/False")]
public class FalseCondition : Condition
{
    public override bool Value => false;
}
