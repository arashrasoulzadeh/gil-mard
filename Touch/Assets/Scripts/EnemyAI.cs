﻿using UnityEngine;
using System.Collections;
using System.Timers;

public class EnemyAI : MonoBehaviour {

	public GameObject EnemyBullet;
	public float Power;
	public bool Created = false;

	void Start()
	{
		Time.timeScale=1.0f;
	}
	void Update()
	{
			if(Created == false)
			{
				GameObject obj = Instantiate(EnemyBullet, transform.position, transform.rotation) as GameObject;
				obj.GetComponent<Rigidbody>().AddForce(transform.forward * Power);
				Created = true;
				StartCoroutine(EnemyWatingvoid());
			}
	}

	IEnumerator EnemyWatingvoid()
	{
		yield return new WaitForSeconds(5);
		Created = false;
	}

}
