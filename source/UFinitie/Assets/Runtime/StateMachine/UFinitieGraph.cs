using System;
using System.Linq;
using UnityEngine;
using XNode;

[CreateAssetMenu(menuName = "UFinitie/Create/State machine graph")]
public class UFinitieGraph : NodeGraph
{
    private RootNode mRoot;

    public RootNode Root => mRoot != null ? mRoot : FindRoot();

    public override Node AddNode(Type type)
    {
        if (type == typeof(RootNode))
        {
            if (mRoot == null)
            {
                mRoot = base.AddNode(type) as RootNode;
                return mRoot;
            }

            return null;
        }

        return base.AddNode(type);
    }

    private RootNode FindRoot()
    {
        mRoot = nodes.FirstOrDefault(node => node is RootNode) as RootNode;
        if (mRoot == null)
            mRoot = AddNode<RootNode>();

        return mRoot;
    }
}