using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitManager : MonoBehaviour {

    public GameObject unit;
    public Transform tr;

	void Start () {
    }

    public void CreateUnit()
    {
        GameObject obj = Instantiate(unit);
        obj.transform.position = tr.position;
    }
}
