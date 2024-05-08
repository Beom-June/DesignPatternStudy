using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 평소 보스몹 'ConcreteProduct' class
/// </summary>
class NormalBoss : Boss
{
	void Start()
	{
		type = BossType.NormalBoss;
		hp = 200;
		exp = 15;

        name = "Normal Boss";
        Debug.Log (this.name + " : 출현!!");
	}

    public override void Attack()
    {
        Debug.Log(this.name + " : 공격!!");
    }
}
