using NullGames;
using UnityEngine;

public class Script : MonoBehaviour 
{
	public GameObject poolObj;
	public int size=4;
	public Pool pool;

	private void Start()
	{
		pool = new Pool (poolObj, size);
	}

	private void Update()
	{
		if(Input.GetMouseButtonDown(0))
		{
			pool.SetActiveNextObject ();
		}
	}
}
