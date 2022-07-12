using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace PlayerPrefTest
{
	public class UIInteractor : MonoBehaviour
	{
		[SerializeField] Slider s;


		void Start()
		{
			s.value = AudioController.GetActualVolume();
		}


	}
}
