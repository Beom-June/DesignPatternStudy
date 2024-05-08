using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ConcreteState 클래스 : 기 모은 후 공격
public class ConcreteStateSkill2 : State2 {

	public override void DoAction(MyState state)
	{
		Debug.Log("Forward Attack !!!");
		StartCoroutine("HandleSkill");
	}

	IEnumerator HandleSkill()
	{
        transform.eulerAngles = new Vector3(0, 90, 0);
        transform.position = new Vector3(0, 1.0f, 0);

        transform.Translate(Vector3.forward * 3.0f);
        yield return new WaitForSeconds(0.1f);
        transform.Translate(Vector3.back * 1.0f);
        yield return new WaitForSeconds(0.1f);
        transform.Translate(Vector3.forward * 1.0f);
        yield return new WaitForSeconds(0.1f);

        transform.position = new Vector3(0, 1.0f, 0);

        GetComponent<MyAction8>().setActionType(MyState.STATE_STANDING);
    }
}
