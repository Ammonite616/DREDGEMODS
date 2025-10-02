using UnityEngine;
using Winch.Core;

namespace plentifulseas
{
	public class plentifulseas : MonoBehaviour
	{
		public void Awake()
		{
			WinchCore.Log.Debug($"{nameof(plentifulseas)} has loaded!");
		}
	}
}
