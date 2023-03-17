using UnityEngine;
using UnityEngine.UI;

public abstract class MenuStateActionBase<TMenuView> : StateAction
    where TMenuView : MonoBehaviour
{
    protected TMenuView _view;
    private MenuRunner _runner;

    public override void OnEnter()
    {
        _view = FindAnyObjectByType<TMenuView>(FindObjectsInactive.Include);
        _runner = _view.GetComponentInParent<MenuRunner>();

        _view.gameObject.SetActive(true);
    }

    public override void OnExit()
    {
        _view.gameObject.SetActive(false);
        _view = null;
        _runner = null;
    }

    protected void RegisterButtonClick(Button button, MenuMode mode)
    {
        button.onClick.AddListener(() =>
        {
            MenuModeService.Mode = mode;
            _runner.Next();
        });
    }
}
