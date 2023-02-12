using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewStateMachine", menuName = "Finite State Machine/Create/State machine")]
[System.Serializable]
public class StateMachine : ScriptableObject
{
    private IState _activeState;
    private List<Transition> _activeTransitions = new();

    public List<IState> States { get; private set; }
    public Dictionary<IState, List<Transition>> Transitions { get; private set; }

    public void Fire(IState state)
    {
        _activeState?.OnEnter();
        _activeState = state;
        _activeState?.OnExit();

        _activeTransitions = Transitions[_activeState];
    }

    public void Update()
    {
        foreach (var transition in _activeTransitions)
            transition.Execute(this);
    }

    public TState CreateState<TState>(Func<TState> creator = null)
        where TState : ScriptableObject, IState
    {
        TState state = creator switch
        {
            not null => creator(),
            _ => CreateInstance<TState>()
        };

        States.Add(state);
        return state;
    }

    public Transition CreateTranstion(IState from, IState left, Func<Transition> creator = null)
    {
        Transition transition = creator switch
        {
            not null => creator(),
            _ => CreateInstance<Transition>()
        };

        transition.From = from;
        transition.To = left;

        if (Transitions.TryGetValue(from, out var transitions))
            transitions.Add(transition);
        else
            Transitions.Add(from, new List<Transition> { transition });

        return transition;
    }
}