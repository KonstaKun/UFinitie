using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMenuView : MonoBehaviour
{
    [SerializeField] private Button _newGameButton;
    [SerializeField] private Button _loadGameButton;
    [SerializeField] private Button _returnButton;

    public Button NewGameButton => _newGameButton;
    public Button LoadGameButton => _loadGameButton;
    public Button ReturnButton => _returnButton;
}
