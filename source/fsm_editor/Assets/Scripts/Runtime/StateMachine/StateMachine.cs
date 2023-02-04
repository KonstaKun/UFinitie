using System;
using System.Collections;
using System.Collections.Generic;

public class StateMachine<TTrigger>
{
    private Dictionary<Type, IState> _states = new();
    private Dictionary<(Type fromStateTime, TTrigger trigger), IState> _transitions = new();

    private IState _activeState = null;

    public void Fire(TTrigger trigger)
    {
        var activeStateType = _activeState?.GetType();
        var transitionDefinition = (activeStateType, trigger);
        var state = _transitions[transitionDefinition];

        _activeState?.OnExit();
        _activeState = state;
        _activeState?.OnEnter();
    }

    public void AddState(IState state) =>
        _states[state.GetType()] = state;

    public void AddTransition(IState fromState, IState toState, TTrigger trigger) =>
        _transitions[(fromState?.GetType(), trigger)] = _states[toState?.GetType()];
}
