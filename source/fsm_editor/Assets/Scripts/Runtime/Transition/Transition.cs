using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ITransition<TTrigger>
{
    IState StateFrom { get; }
    IState StateTo { get; }
    TTrigger Trigger { get; }
}
