﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindClosest : MonoBehaviour {

	GameObject[] mesas;

	// Update is called once per frame
	void Update () {
		FindClosestMesa ();
	}

	void FindClosestMesa()
	{
		float distanceToClosestMesa = Mathf.Infinity;
		GameObject closetsMesa = null;
		mesas = GameObject.FindGameObjectsWithTag("mesas");

		foreach (GameObject currentMesa in mesas) {
			float distanceToMesa = (currentMesa.transform.position - this.transform.position).sqrMagnitude;
			if (distanceToMesa < distanceToClosestMesa) {
				distanceToClosestMesa = distanceToMesa;
				closetsMesa = currentMesa;
			}
		}

		Debug.Log(closetsMesa);

		
	}

}
