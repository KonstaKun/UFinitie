using System;

[NodeTint("#008A63"), NodeWidth(110)]
[Serializable]
public sealed class RootNode : BaseNode
{
    [Output(ShowBackingValue.Never, ConnectionType.Override)] public ExecutionLink Out;

    public override ExecutionMode Mode => ExecutionMode.Continue;

    public override ExecutionMode TryNext(out BaseNode next)
    {
        next = null;

        var child = GetOutputPort(nameof(Out))?.Connection.node as BaseNode;
        if (child != null)
        {
            next = child;
            return ExecutionMode.Success;
        }

        return ExecutionMode.None;
    }
}
