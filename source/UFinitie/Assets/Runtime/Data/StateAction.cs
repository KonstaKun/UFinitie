using UnityEngine;

public abstract class StateAction : ScriptableObject
{
    public abstract void OnEnter();
    public abstract void OnExit();
}