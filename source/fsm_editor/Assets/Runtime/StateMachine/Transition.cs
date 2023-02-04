using System;
using UnityEngine;

public sealed class Transition : ScriptableObject
{
    public State From;
    public State To;
    public Decision Decision;

    public void Execute(StateMachine stateMachine)
    {
        if (Decision.Decide())
            stateMachine.Fire(To);
    }
}