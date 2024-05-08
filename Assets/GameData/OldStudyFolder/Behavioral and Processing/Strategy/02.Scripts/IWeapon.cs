using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 인터페이스 : Shoot() 메소드만 있는 추상클래스
//public abstract class IWeapon {
//	public virtual void Shoot() {}
//}

public interface IWeapon{
	void Shoot(GameObject obj); 
}
