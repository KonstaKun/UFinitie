using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[NodeTint("#8A66BA")]
public sealed class StateNode : BaseNode
{
    [Input(ShowBackingValue.Never)] public ExecutionLink In;
    [Output(connectionType = ConnectionType.Multiple)] public ExecutionLink Out;

    [SerializeField] private List<StateAction> _actions = new List<StateAction>();

    [NonSerialized] public bool IsActive;

    public override ExecutionMode Mode => ExecutionMode.Success;

    public override void OnEnter()
    {
        IsActive = true;

        _actions.ForEach(static action => action.OnEnter());
    }

    public override void OnExit()
    {
        IsActive = false;

        _actions.ForEach(static action => action.OnExit());
    }

    public override ExecutionMode TryNext(out BaseNode next)
    {
        next = null;
        var children = GetSortedOutportNodes<BaseNode>(nameof(Out)).ToList();
        foreach (var child in children)
        {
            switch (child.Mode)
            {
                case ExecutionMode.Success:
                    next = child;
                    return ExecutionMode.Success;
                case ExecutionMode.Continue:
                    var mode = child.TryNext(out next);
                    if (mode == ExecutionMode.Pass)
                        continue;
                    return mode;
                default:
                    throw new NotImplementedException($"{child.name} has {child.Mode} mode");
            }
        }

        return ExecutionMode.Pass;
    }

    private List<TNode> GetSortedOutportNodes<TNode>(string outportName) where TNode : BaseNode
    {
        var children = GetOutputPort(outportName)
            .GetConnections()
            .Where(port => port.IsInput)
            .Select(port => port.node as TNode)
            .ToList();

        children.Sort(static (x, y) => x.position.y > y.position.y ? 1 : -1);
        return children;
    }
}
