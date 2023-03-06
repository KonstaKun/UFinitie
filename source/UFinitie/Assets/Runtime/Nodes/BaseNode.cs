using System;
using XNode;

[Serializable] public struct ExecutionLink { }

[Serializable]
public abstract class BaseNode : Node
{
    public override object GetValue(NodePort port) => null;

    public virtual BaseNode OnMoveNext() { return null; }
    
    public virtual void OnEnter() { }

    public virtual void OnExit() { }
}
