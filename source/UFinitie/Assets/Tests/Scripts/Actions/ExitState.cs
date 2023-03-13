using UnityEngine;

[CreateAssetMenu(menuName = "Menu/Action/Exit")]
public class ExitState : StateAction
{
    public override void OnEnter()
    {
        if (Application.isPlaying)
            Application.Quit();  
    }

    public override void OnExit() { }
}
