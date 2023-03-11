using UnityEditor.UI;
using UnityEngine;
using XNodeEditor;

[CustomNodeEditor(typeof(StateNode))]
public class StateNodeView : NodeEditor
{
    public override Color GetTint()
    {
        if (Application.isPlaying && (target as StateNode).IsActive)
            return Color.gray;
        return base.GetTint();
    }
}
