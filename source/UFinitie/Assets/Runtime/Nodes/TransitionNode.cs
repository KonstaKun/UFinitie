using System;
using UnityEngine;

[NodeTint("#5E76C2")]
public sealed class TransitionNode : BaseNode
{
    [Input(ShowBackingValue.Never)] public ExecutionLink In;
    [Output(connectionType = ConnectionType.Override)] public ExecutionLink Out;

    [SerializeField] private Condition _condition;

    public override ExecutionMode Mode => ExecutionMode.Continue;

    public override ExecutionMode TryNext(out BaseNode next)
    {
        next = null;

        if (_condition != null && _condition.Value)
        {
            var child = GetOutputPort(nameof(Out)).Connection?.node as BaseNode;
            if (child != null)
            {
                switch (child.Mode)
                {
                    case ExecutionMode.Success:
                        next = child;
                        return ExecutionMode.Success;
                    case ExecutionMode.Continue:
                        return child.TryNext(out next);
                    default:
                        throw new NotImplementedException($"{child.name} has {child.Mode} mode");
                }
            }
        }

        return ExecutionMode.Pass;
    }
}