using UnityEngine;
using UnityEngine.UI;

public class UFinitieRunner : MonoBehaviour
{
    [SerializeField] private UFinitieGraph _graph;
    [SerializeField] private Text _text;
    [SerializeField] private Button _startButton;
    [SerializeField] private Button _nextButton;
    [SerializeField] private Button _finishButton;
    
    private UFinitieGraphController _controller;

    private void Awake()
    {
        _controller = new UFinitieGraphController();
    }

    private void Start()
    {
        _startButton.onClick.AddListener(() => _controller.Start(_graph));
        _nextButton.onClick.AddListener(() => _controller.Next());
        _finishButton.onClick.AddListener(() => _controller.Reset());
    }
}
