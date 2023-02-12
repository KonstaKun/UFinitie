using System.Collections.Generic;
using UnityEngine;

public interface IState
{
    public string Name { get; set; }
    public List<StateDefinition> Definitions { get; set; }
    void OnEnter();
    void OnExit();
}

[System.Serializable]
public sealed class State : ScriptableObject, IState
{
    public string Name { get; set; }

    public List<StateDefinition> Definitions { get; set; } = new();

    public void OnEnter()
    {
        foreach (var definition in Definitions)
            definition.OnEnter();
    }

    public void OnExit()
    {
        foreach (var definition in Definitions)
            definition.OnEnter();
    }

    public override string ToString()
    {
        return Name;
    }
}
