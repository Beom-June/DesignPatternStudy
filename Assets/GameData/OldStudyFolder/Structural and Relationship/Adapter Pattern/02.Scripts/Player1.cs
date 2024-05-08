using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour
{
	void Start () {
        //gameObject.AddComponent<UnitAction>();
        IUnitAction act = gameObject.GetComponent<UnitAction>();
        act.NormalMove(this.transform);
    }
}
