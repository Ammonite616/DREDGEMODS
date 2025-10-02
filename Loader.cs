using UnityEngine;

namespace plentifulseas
{
	public class Loader
	{
		/// <summary>
		/// This method is run by Winch to initialize your mod
		/// </summary>
		public static void Initialize()
		{
			var gameObject = new GameObject(nameof(plentifulseas));
			gameObject.AddComponent<plentifulseas>();
			GameObject.DontDestroyOnLoad(gameObject);
		}
	}
}