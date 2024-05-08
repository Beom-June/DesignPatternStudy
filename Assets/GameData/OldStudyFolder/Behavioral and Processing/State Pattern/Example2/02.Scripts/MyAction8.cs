using UnityEngine;
using System.Collections;

public enum MyState
{
    STATE_STANDING,
    STATE_JUMPING,
    STATE_DUCKING,
    STATE_DIVING,
    STATE_SKILL
}

public class MyAction8 : MonoBehaviour {

    private MyState state;

	// Concrete클래스들의 접근점(추상 클래스)
	private State2 myState;

	// 상태 클래스 교환...
	public void setActionType (MyState state) {

        // 현재 상태 저장
        this.state = state;

        // 다양한 상태 중에 어떤 것을 가져와야 할 지 모르므로
        // 추상 클래스를 대표로 해서 가져온다.
		Component c = gameObject.GetComponent<State>() as Component;

		if (c != null) {
			Destroy(c);
		}

        switch (state)
        {
            case MyState.STATE_STANDING:
                myState = gameObject.AddComponent<ConcreteStateStand2>();
                myState.DoAction(state);
                break;
            case MyState.STATE_JUMPING:
                myState = gameObject.AddComponent<ConcreteStateJump2>();
                myState.DoAction(state);
                break;
            case MyState.STATE_DUCKING:
                myState = gameObject.AddComponent<ConcreteStateDown2>();
                myState.DoAction(state);
                break;
            case MyState.STATE_DIVING:
                myState = gameObject.AddComponent<ConcreteStateAttack2>();
                myState.DoAction(state);
                break;
            case MyState.STATE_SKILL:
                myState = gameObject.AddComponent<ConcreteStateSkill2>();
                myState.DoAction(state);
                break;
            default:
                break;
        }
    }

    void Start () 
	{
        setActionType(MyState.STATE_STANDING);
	}

    void Update()
    {
        switch (state)
        {
            case MyState.STATE_STANDING:
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    setActionType(MyState.STATE_JUMPING);
                }
                else if (Input.GetKeyDown(KeyCode.DownArrow))
                {
                    setActionType(MyState.STATE_DUCKING);
                }
                break;
            case MyState.STATE_JUMPING:
                if (Input.GetKeyDown(KeyCode.DownArrow))
                {
                    setActionType(MyState.STATE_DIVING);
                }
                break;
            case MyState.STATE_DUCKING:
                if (Input.GetKeyUp(KeyCode.DownArrow))
                {
                    setActionType(MyState.STATE_STANDING);
                }
                break;
            default:
                break;
        }
    }
}
