using UnityEngine;
using UnityEngine.UI;

public class UFinitieProcessor : MonoBehaviour
{
    [SerializeField] private UFinitieGraph _graph;
    [SerializeField] private Text _text;

    public void Start()
    {
        _graph.Initialize();
    }

    public void MoveNext()
    {
        _graph.MoveNext();
    }

    public void Reset()
    {
        _graph.Reset();
    }
}
