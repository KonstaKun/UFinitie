using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using XNode;

[NodeTint("#8A66BA")]
public sealed class StateNode : BaseNode
{
    [Input(ShowBackingValue.Never)] public ExecutionLink In;
    [Output(connectionType = ConnectionType.Multiple)] public ExecutionLink Out;

    [SerializeField] private List<StateAction> _actions = new List<StateAction>();

    public override void OnEnter()
    {
        _actions.ForEach(static action => action.OnEnter());
    }

    public override void OnExit()
    {
        _actions.ForEach(static action => action.OnExit());
    }

    public override BaseNode OnMoveNext()
    {
        var children = GetChildren().ToList();
        children.Sort(static (x, y) => x.position.y > y.position.y ? 1 : -1);

        BaseNode node = this;
        foreach (var child in children)
        {
            var next = child.OnMoveNext();
            if (next != null)
            {
                node = next;
                break;
            }
        }

        return node;
    }

    private IEnumerable<BaseNode> GetChildren()
    {
        return GetOutputPort(nameof(Out))
            .GetConnections()
            .Where(port => port.IsInput)
            .Select(port => port.node as BaseNode);
    }
}
