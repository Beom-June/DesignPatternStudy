using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum BossType
{
	NormalBoss,
	EventBoss
}

/// <summary>
/// The 'Product' abstract class
/// </summary>
abstract class Boss : MonoBehaviour
{
	protected BossType type;
	protected int hp;
	protected int exp;
    public abstract void Attack();
}
