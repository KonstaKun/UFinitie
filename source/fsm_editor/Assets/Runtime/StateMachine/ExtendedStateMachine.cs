using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewStateMachine", menuName = "Finite State Machine/Create/Extended state machine")]
[System.Serializable]
public class ExtendedStateMachine : StateMachine, IState
{
    public string Name { get; set; }
    public List<StateDefinition> Definitions { get; set; }

    public void OnEnter()
    {
        foreach (var action in Definitions)
            action.OnEnter();
    }

    public void OnExit()
    {
        foreach (var action in Definitions)
            action.OnEnter();
    }

    public override string ToString()
    {
        return Name;
    }
}