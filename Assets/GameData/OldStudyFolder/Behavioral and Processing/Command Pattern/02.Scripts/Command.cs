using UnityEngine;
using System.Collections;

// 인터페이스 : Execute() 메소드만 있는 추상클래스
public abstract class CommandKey {
	public virtual void Execute(Transform tr, Vector3 newPos) {}
	public virtual void Undo(Transform tr) {}
}

// Concrete Command 객체 : 직접적으로 동작하는 객체
public class CommandMoveRight : CommandKey {

	Vector3 prevPos;

	public override void Execute(Transform tr, Vector3 newPos)
	{
		prevPos = tr.position;
		tr.Translate(newPos);
	}

	public override void Undo(Transform tr)
	{
		tr.position = prevPos;
	}
}

public class CommandMoveForward : CommandKey {

	Vector3 prevPos;

	public override void Execute(Transform tr, Vector3 newPos)
	{
		prevPos = tr.position;
		tr.Translate(newPos);
	}

	public override void Undo(Transform tr)
	{
		tr.position = prevPos;
	}
}
