using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deactivator : MonoBehaviour 
{
	private bool isActived;
	private float lifeTime=2f;
	private float timer;

	private void OnEnable()
	{
		isActived = true;
		timer = lifeTime;
	}

	private void Update()
	{
		if(isActived)
		{
			timer -= Time.deltaTime;
			if(timer < 0)
			{
				isActived = false;
				gameObject.SetActive (false);
			}
		}
	}

	private void OnDisable()
	{
		timer = lifeTime;
	}
}
