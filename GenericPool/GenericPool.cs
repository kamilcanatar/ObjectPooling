using System;
using System.Collections.Generic;

namespace NullGames
{
	public class GenericPool <T>
	{
		private const int DEFAULT_SIZE=2;

		private T[] values;

		private int index;

		public GenericPool ()
		{
			values = new T[DEFAULT_SIZE];
			index = -1;
		}

		public void Add(T value)
		{
			index++;

			if(index >= values.GetLength(0))
			{
				T[] temp=new T[values.GetLength(0)];
				Array.Copy (values, temp, values.GetLength (0));
				values = new T[values.GetLength (0) * 2];
				Array.Copy (temp, values, temp.GetLength (0));
			}

			values [index] = value;
		}

		public T Get(int index)
		{
			return values [index];
		}

		public int GetSize()
		{
			return index + 1;
		}
	}
}