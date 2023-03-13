using System;
using XNode;


public abstract class BaseNode : Node
{
    public virtual ExecutionMode Mode => ExecutionMode.None;

    public virtual void OnEnter() { }

    public virtual void OnExit() { }
    
    public virtual ExecutionMode TryNext(out BaseNode next)
    {
        next = null;
        return Mode;
    }

    public override object GetValue(NodePort port) => null;
}
