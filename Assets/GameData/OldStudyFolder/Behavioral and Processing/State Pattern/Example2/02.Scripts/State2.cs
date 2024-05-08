using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// State 추상클래스
public abstract class State2 : MonoBehaviour
{
    public abstract void DoAction(MyState state);
};

// 상태 인터페이스 클래스
//public interface State
//{
//	void DoAction();
//};
