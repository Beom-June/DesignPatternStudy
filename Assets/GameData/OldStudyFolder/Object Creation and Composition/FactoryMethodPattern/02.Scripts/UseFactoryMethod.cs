using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UseFactoryMethod : MonoBehaviour {

    BossGenerator factory = null;
    public Text desc;

	void Start () {
        //factory = new BossGenerator();
        factory = GetComponent<BossGenerator>();

        if (factory.type == BossType.NormalBoss)
        {
            desc.text = "Normal Boss";
        }
        else if (factory.type == BossType.EventBoss)
        {
            desc.text = "Event Boss";
        }

        // 로직에 따라 특정 위치 지정
        Transform tran = this.gameObject.transform;

        // 무엇이 만들어질지 여기서는 모른다.
        // 이벤트 기간에 맞춰 팩토리 클래스에서 타입이 변경되었다면
        // 해당 보스가 등장하게 된다.
        factory.CreateBoss(tran);
    }
}
