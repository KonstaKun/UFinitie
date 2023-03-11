using UnityEngine;
using XNodeEditor;

[CustomNodeGraphEditor(typeof(UFinitieGraph))]
public class UFinityGraphView : NodeGraphEditor
{
    private const string EDITOR_WINDOW_TITLE = "UFinitie Graph Editor";

    public override void OnOpen()
    {
        base.OnOpen();
        window.titleContent.text = EDITOR_WINDOW_TITLE;
    }

    public override void OnGUI()
    {
        base.OnGUI();
        if (Application.isPlaying)
            NodeEditorWindow.current.Repaint();
    }
}
