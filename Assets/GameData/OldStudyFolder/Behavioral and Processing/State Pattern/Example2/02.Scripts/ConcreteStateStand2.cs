using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ConcreteState 클래스 : 서기
public class ConcreteStateStand2 : State2 {

	public override void DoAction(MyState state)
	{
		Debug.Log("Stand !!!");
		StartCoroutine(HandleStand(state));
	}

	IEnumerator HandleStand(MyState state)
	{
        transform.eulerAngles = new Vector3(0, 90, 0);
		transform.position = new Vector3(0, 1.0f, 0);
		yield return null;
	}
}
