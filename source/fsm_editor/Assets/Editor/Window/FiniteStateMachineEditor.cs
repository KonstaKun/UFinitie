using UnityEditor;
using UnityEngine;
using UnityEditor.Callbacks;
using UnityEngine.UIElements;

public class FiniteStateMachineEditor : EditorWindow
{
    [SerializeField] private VisualTreeAsset _visualTreeAsset = default;

    private StateMachine _activeStateMachine;


    [OnOpenAsset(OnOpenAssetAttributeMode.Execute)]
    public static bool ShowEditor(int instanceID, int line)
    {
        Object item = EditorUtility.InstanceIDToObject(instanceID);
        if (item is StateMachine)
        {
            FiniteStateMachineEditor wnd = GetWindow<FiniteStateMachineEditor>();
            wnd.titleContent = new GUIContent("Finite State Machine Editor");
            wnd.Load((StateMachine)item);

            return true;
        }

        return false;
    }

    public void CreateGUI()
    {
        VisualElement root = rootVisualElement;
        _visualTreeAsset.CloneTree(root);
    }

    private void Load(StateMachine activeStateMachine)
    {
        _activeStateMachine = activeStateMachine;
        
    }
}
