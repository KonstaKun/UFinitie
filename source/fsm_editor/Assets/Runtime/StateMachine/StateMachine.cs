using UnityEngine;

public class StateMachine : ScriptableObject
{
    private State _activeState;

    public void Fire(State state)
    {
        if (_activeState != null)
            _activeState.OnEnter();

        _activeState = state;
        
        if (_activeState != null)
            _activeState.OnExit();
    }
}
