using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// The 'Adaptee' class
/// </summary>

public class UnitAction : MonoBehaviour, IUnitAction
{
    // 이동
    public void NormalMove(Transform tr)
    {
        tr.Translate(Vector3.forward * 1.0f);
        Debug.Log("노멀 이동");
    }

    // 정지
    public void NormalStop(Transform tr)
    {
        Debug.Log("노멀 정지");
    }
}
