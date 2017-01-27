using UnityEngine;
using System.Collections.Generic;

namespace NullGames
{
	public class Pool 
	{
		private GenericPool<GameObject> pool=new GenericPool<GameObject>();

		private int index;

		public Pool(GameObject[] gameObjects)
		{
			for(int i=0;i<gameObjects.GetLength(0);i++)
			{
				pool.Add (gameObjects [i]);
				pool.Get (i).SetActive (false);
			}

			index = -1;
		}

		public Pool(GameObject gameObject,int size)
		{
			for(int i=0;i<size;i++)
			{
				GameObject obj=GameObject.Instantiate (gameObject) as GameObject;
				obj.AddComponent<Deactivator> ();
				pool.Add (obj);
				pool.Get (i).SetActive (false);
			}

			index = -1;
		}

		public void SetActiveNextObject()
		{
			if(index >= pool.GetSize() - 1)
			{
				index = -1;
			}

			if(pool.Get(index+1).activeInHierarchy)
			{
				Debug.LogError ("No available inactive object in pool");
				return;
			}
			index++;
			Debug.Log (index);
			pool.Get (index).SetActive (true);
		}
	}
}
