using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class NodeView : Node
{
	private State _state;

	public NodeView(State state)
	{
		_state = state;
		title = state.Name;
	}
}
