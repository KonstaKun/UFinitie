using UnityEngine;
using UnityEngine.UI;

public class MenuRunner : MonoBehaviour
{
    [SerializeField] private UFinitieGraph _graph;

    private UFinitieGraphController _controller;

    private void Awake()
    {
        _controller = new UFinitieGraphController();
    }

    private void Start()
    {
        _controller.Run(_graph);
    }

    public void Next() => _controller.Next();
}
