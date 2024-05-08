using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ConcreteState 클래스 : 내려찍기
public class ConcreteStateAttack2 : State2 {

	public override void DoAction(MyState state)
	{
		Debug.Log("Down Attack !!!");
		StartCoroutine(HandleAttack(state));
	}

	IEnumerator HandleAttack(MyState state)
	{
		transform.position = new Vector3(0, 0.2f, 0);
		yield return new WaitForSeconds(0.1f);
		transform.position = new Vector3(0, 1.2f, 0);
		yield return new WaitForSeconds(0.1f);
		transform.position = new Vector3(0, 0.2f, 0);
		yield return new WaitForSeconds(0.1f);

		transform.position = new Vector3(0, 1.0f, 0);

        GetComponent<MyAction8>().setActionType(MyState.STATE_STANDING);
		//state = STATE.STATE_STANDING;
    }
}
