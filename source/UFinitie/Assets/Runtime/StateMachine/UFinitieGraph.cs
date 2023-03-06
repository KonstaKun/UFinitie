using System;
using System.Linq;
using UnityEngine;
using XNode;

[CreateAssetMenu(menuName = "UFinitie/Create/State machine graph")]
public class UFinitieGraph : NodeGraph
{
    private RootNode _root;
    private BaseNode _currentNode;

    public void Initialize()
    {
        _root = GetRoot();
        if (_root == null)
            _root = AddNode<RootNode>();

        _currentNode = _root;
        MoveNext();
    }

    public void MoveNext()
    {
        var node = _currentNode.OnMoveNext();
        if (node != _currentNode)
        {
            _currentNode.OnExit();
            _currentNode = node;
            _currentNode.OnEnter();
        }
    }

    public void Reset()
    {
        _currentNode = _root;
    }

    public override Node AddNode(Type type)
    {
        if (type == typeof(RootNode))
        {
            if (_root == null)
            {
                _root = base.AddNode(type) as RootNode;
                return _root;
            }

            return null;
        }

        return base.AddNode(type);
    }

    private RootNode GetRoot()
    {
        return _root != null ? _root : nodes.FirstOrDefault(node => node is RootNode) as RootNode;
    }
}