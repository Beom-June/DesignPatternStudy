using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 설날 코스튬 보스몹 'ConcreteProduct' class
/// </summary>
class EventBoss : Boss
{
	void Start()
	{
		type = BossType.EventBoss;
		hp = 200;
		exp = 20;

        name = "Event Boss";
        Debug.Log (this.name + " : 출현!!");
	}

    public override void Attack()
    {
        Debug.Log(this.name + " : 공격!!");
    }
}
