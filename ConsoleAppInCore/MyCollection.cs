using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppInCore
{

	/// <summary>
	/// This is collection example.
	/// Generic collection & Non-generic collection
	/// </summary>
	/// 

	public class MyCollection
	{
		/// <summary>
		/// List<T> is a generic collection.
		/// </summary>
		public void ListExamleCreate()
		{
			List<int> nos = new List<int>();
			nos.Add(1);
			nos.Add(2);
			nos.Add(3);
			nos.Add(4);
			nos.Add(5);

			foreach (var no in nos)
			{
				Console.WriteLine(no);
			}
		}
	}
}
