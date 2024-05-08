using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A 'ConcreteCreator' class
/// </summary>
class BossGenerator : BossFactory
{
    // 설날 코스튬 보스몹 지정
    public BossType type = BossType.EventBoss;
    public GameObject _normalBoss;
    public GameObject _eventBoss;

    public override void CreateBoss(Transform tran)
	{
        if (type == BossType.NormalBoss)
        {
            GameObject boss = Instantiate(_normalBoss) as GameObject;
            boss.transform.position = tran.position;
            boss.transform.localRotation = tran.localRotation;
        }
        else if (type == BossType.EventBoss)
        {
            GameObject boss = Instantiate(_eventBoss) as GameObject;
            boss.transform.position = tran.position;
            boss.transform.localRotation = tran.localRotation;
        }
    }
}
