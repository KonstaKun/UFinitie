using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class FiniteStateMachineEditor : EditorWindow
{
    [SerializeField] private VisualTreeAsset _visualTreeAsset = default;

    [MenuItem("Tools/Finite State MachineEditor/Open Editor")]
    public static void ShowEditor()
    {
        FiniteStateMachineEditor wnd = GetWindow<FiniteStateMachineEditor>();
        wnd.titleContent = new GUIContent("Finite State Machine Editor");
    }

    public void CreateGUI()
    {
        // Each editor window contains a root VisualElement object
        VisualElement root = rootVisualElement;
        // Load Tree From Builder
        _visualTreeAsset.CloneTree(root);
    }

    private void OnSelectionChange()
    {

    }
}
