using UnityEngine;

public interface IGraphVisitor
{
    void Visit(BaseNode baseNode) => Debug.Log("There is a node without implementation");
    void Visit(StateNode stateNode);
    void Visit(TransitionNode transitionNode);
}
