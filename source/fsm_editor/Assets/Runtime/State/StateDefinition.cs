using UnityEngine;

public abstract class StateDefinition : ScriptableObject
{
    public abstract void OnEnter();
    public abstract void OnExit();
}