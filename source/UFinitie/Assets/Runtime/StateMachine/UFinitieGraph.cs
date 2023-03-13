using System;
using System.Linq;
using UnityEngine;
using XNode;

[CreateAssetMenu(menuName = "UFinitie/State Machine Graph")]
public class UFinitieGraph : NodeGraph
{
    private RootNode _root;

    public RootNode Root => _root != null ? _root : FindRoot();

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

    private RootNode FindRoot()
    {
        _root = nodes.FirstOrDefault(node => node is RootNode) as RootNode;
        if (_root == null)
            _root = AddNode<RootNode>();

        return _root;
    }
}