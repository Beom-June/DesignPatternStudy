using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// The 'Target' class
/// </summary>

// 인터페이스 : 원하는 기능
public interface INewAction
{
    void EventMove(Transform tr);
    void EventStop(Transform tr);
}
