using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FactoryMethodUse : MonoBehaviour {

    RaceFactory factory = null;

	void Start () {
		factory = GetComponent<FactoryMethod>().getFactory();

		GameObject capacity = factory.makeCapacityBuilding();
		GameObject building = factory.makeUnitBuilding();

        capacity.GetComponent<RaceCapacity>().expand();
		building.GetComponent<UnitBuilding>().produce();
    }
}
