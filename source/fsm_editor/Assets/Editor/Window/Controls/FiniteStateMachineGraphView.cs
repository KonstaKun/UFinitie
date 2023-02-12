using System.Collections;
using System.Collections.Generic;
using UnityEngine.UIElements;
using UnityEditor.Experimental.GraphView;
using UnityEditor;

public class FiniteStateMachineGraphView : GraphView
{
	public new class UxmlFactory : UxmlFactory<FiniteStateMachineGraphView, GraphView.UxmlTraits> { }

	public FiniteStateMachineGraphView()
	{
		this.Insert(0, new GridBackground());

		this.AddManipulator(new ContentZoomer());
		this.AddManipulator(new ContentDragger());
		this.AddManipulator(new SelectionDragger());
		this.AddManipulator(new RectangleSelector());

		var styleSheet = AssetDatabase.LoadAssetAtPath<StyleSheet>("Assets/Editor/Window/FiniteStateMachineEditor.uss");
		this.styleSheets.Add(styleSheet);
	}
}
