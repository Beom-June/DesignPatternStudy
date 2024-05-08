using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// The 'Adapter' class
/// </summary>

public class Adapter : MonoBehaviour, INewAction, IUnitAction
{
    public GameObject shield;

    // For INewAction

    public void EventMove(Transform tr)
    {
        StartCoroutine(CoEventMove(1.0f, tr));
    }

    IEnumerator CoEventMove(float tm, Transform tr)
    {
        shield.SetActive(true);

        // 이벤트로 두 번 이동
        tr.Translate(Vector3.forward * 1.0f);
        Debug.Log("이벤트 이동");
        yield return new WaitForSeconds(tm);

        tr.Translate(Vector3.forward * 1.0f);
        Debug.Log("이벤트 이동");
        yield return new WaitForSeconds(tm);

        shield.SetActive(false);
    }

    public void EventStop(Transform tr)
    {
        Debug.Log("이벤트 정지");
    }


    // For IUnitAction

    public void NormalMove(Transform tr)
    {
        EventMove(tr);
    }

    public void NormalStop(Transform tr)
    {
        EventStop(tr);
    }
}
