using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// The 'Adaptee' interface
/// </summary>

public interface IUnitAction {

    void NormalMove(Transform tr);
    void NormalStop(Transform tr);
}
