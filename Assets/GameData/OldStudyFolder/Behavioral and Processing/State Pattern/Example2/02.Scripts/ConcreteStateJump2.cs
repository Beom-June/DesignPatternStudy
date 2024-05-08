using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ConcreteState 클래스 : 점프
public class ConcreteStateJump2 : State2
{
	float gravity = 0.0f;   // 중력의 값
	Vector3 velocity;       // 캐릭터의 현재 높이 저장값
	const int MAX_CHARGE = 20;

	public override void DoAction(MyState state)
	{
		Debug.Log("Jump !!!");
		velocity = transform.position;
		StartCoroutine(HandleJump(state));
	}

	IEnumerator HandleJump(MyState state)
	{
		gravity = 0.7f;

		while (true)
		{
            if (state == MyState.STATE_DIVING)
            {
                break;
            }

            velocity.y = velocity.y + gravity;

			transform.position = velocity;

			if (velocity.y < 1.0f)
			{
				break;
			}

			gravity = gravity - 0.1f;

			yield return new WaitForSeconds(0.05f);
		}

		gravity = 0.0f;
		velocity.y = 1.0f;
		transform.position = velocity;
        GetComponent<MyAction8>().setActionType(MyState.STATE_STANDING);
        // 위 코드 대신 점프 후 서 있는 상태 하나를 더 만들 수도 있다.
        //state = STATE.STATE_STANDING2;

        yield return null;
	}
}
