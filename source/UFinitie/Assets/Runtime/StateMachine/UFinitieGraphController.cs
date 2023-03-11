using System;
using UnityEngine;

public class UFinitieGraphController
{
    private BaseNode _currentNode;

    public void Start(UFinitieGraph graph)
    {
        if (graph == null)
        {
            Debug.LogException(new ArgumentNullException($"{nameof(graph)}"));
            return;
        }

        _currentNode = graph.Root;
        Next();
    }

    public void Next()
    {
        if (_currentNode == null)
        {
            Debug.LogError($"Please, try call {nameof(Start)} method before {nameof(Next)} one");
            return;
        }

        ExecutionMode mode = _currentNode.TryNext(out var next);
        switch (mode)
        {
            case ExecutionMode.Success:
                _currentNode?.OnExit();
                _currentNode = next;
                _currentNode?.OnEnter();
                break;
            case ExecutionMode.Pass:
                break;
            default:
                Debug.LogException(new ArgumentException());
                break;
        }
    }

    public void Reset()
    {
        _currentNode?.OnExit();
        _currentNode = null;
    }
}