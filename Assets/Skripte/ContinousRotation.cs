﻿using UnityEngine;
using System.Collections;

public class ContinousRotation : MonoBehaviour 
{

	public float m_AngleInDegreeX = 0.0f;
	public float m_AngleInDegreeY = 0.0f;
	public float m_AngleInDegreeZ = 0.0f;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.rotation = Quaternion.Euler (
			transform.rotation.eulerAngles.x + m_AngleInDegreeX * Time.deltaTime,
			transform.rotation.eulerAngles.y + m_AngleInDegreeY * Time.deltaTime,
			transform.rotation.eulerAngles.z + m_AngleInDegreeZ * Time.deltaTime);
	}
}