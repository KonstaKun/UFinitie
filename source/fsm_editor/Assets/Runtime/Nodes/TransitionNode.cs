using System;
using UnityEngine;
using XNode;

[NodeTint("#5E76C2")]
public sealed class TransitionNode : BaseNode
{
    [Input(ShowBackingValue.Never)] public ExecutionLink In;
    [Output(connectionType = ConnectionType.Override)] public ExecutionLink Out;

    [SerializeField] private Condition _condition;

    public override BaseNode OnMoveNext()
    {
        return _condition.Value ? GetOutputPort(nameof(Out)).Connection?.node as BaseNode : null;
    }
}