using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    void Start () {
        //gameObject.AddComponent<Adapter>();
        IUnitAction act = gameObject.GetComponent<Adapter>();
        act.NormalMove(this.transform);
    }
}
