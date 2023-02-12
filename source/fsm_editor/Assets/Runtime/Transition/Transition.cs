using UnityEngine;

[System.Serializable]
public sealed class Transition : ScriptableObject
{
    public IState From { get; set; }
    public IState To { get; set; }
    public Decision Decision { get; set; }

    public void Execute(StateMachine stateMachine)
    {
        if (Decision.Decide())
            stateMachine.Fire(To);
    }

    public override string ToString()
    {
        return $"{From.Name} -> {To.Name}";
    }
}