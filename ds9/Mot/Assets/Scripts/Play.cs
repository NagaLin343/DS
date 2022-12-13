using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Play : MonoBehaviour
{
	[SerializeField]
	private Transform m_tool;

	public float range = 180f;
	public float speed = 1f;
	private float m_timer = 0f;
	private bool m_isDown;

	private void Update()
	{
		var angels = m_tool.localEulerAngles;
		var target = range * (m_isDown ? -1f : 1f);
		var x = Mathf.MoveTowardsAngle(angels.x, target, speed * Time.deltaTime);
		angels.x = x;
		m_tool.localEulerAngles = angels;
	}

	public void OnDown()
	{
		m_isDown = true;
	}

	public void OnUp()
	{
		m_isDown = false;
	}

	public void setIsDown(bool isDown)
	{
		m_isDown = isDown;
	}

}
