using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateManager : MonoBehaviour {

	void Start () {
        Monster monster = new Monster(new Move());
        monster.act();

        monster.setState(new Attack());
        monster.act();

        monster.setState(new Move());
        monster.act();
    }
}
