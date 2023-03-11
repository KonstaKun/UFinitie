using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuView : MonoBehaviour
{
    [SerializeField] private Button _gameButton;
    [SerializeField] private Button _settingsButton;
    [SerializeField] private Button _exitButton;

    public Button GameButton => _gameButton;
    public Button SettingsButton => _settingsButton;
    public Button ExitButton => _exitButton;
}
