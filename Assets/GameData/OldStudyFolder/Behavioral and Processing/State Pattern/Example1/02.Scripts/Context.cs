using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Context 클래스
// 몬스터 클래스
public class Monster
{
    private State state;

    // Constructor
    public Monster(State state)
    {
        this.state = state;
    }

    public void setState(State state)
    {
        this.state = state;
    }

    public void act()
    {
        state.Action();
    }
};
