using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class State : ScriptableObject
{
    public string Name;

    public List<StateAction> Actions = new();
    public List<Transition> Transitions = new();

    public void OnEnter()
    {
        foreach (var action in Actions)
            action.OnEnter();
    }

    public void OnExit()
    {
        foreach (var action in Actions)
            action.OnEnter();
    }

    public void Update()
    {
        foreach (var trans in Transitions)
        {
            //trans.Execute()
        }
    }
}
