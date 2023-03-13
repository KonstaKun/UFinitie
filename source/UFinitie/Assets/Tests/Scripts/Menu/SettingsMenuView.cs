using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsMenuView : MonoBehaviour
{
    [SerializeField] private Button _audioButton;
    [SerializeField] private Button _videoButton;
    [SerializeField] private Button _inputButton;
    [SerializeField] private Button _returnButton;

    public Button AudioButton => _audioButton;
    public Button VideoButton => _videoButton;
    public Button InputButton => _inputButton;
    public Button ReturnButton => _returnButton;
}
