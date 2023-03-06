using System;

[NodeTint("#008A63"), NodeWidth(110)]
[Serializable]
public sealed class RootNode : BaseNode
{
    [Output(ShowBackingValue.Never, ConnectionType.Override)] public ExecutionLink Out;

    public override BaseNode OnMoveNext()
    {
        return GetOutputPort(nameof(Out)).Connection.node as BaseNode;
    }
}
