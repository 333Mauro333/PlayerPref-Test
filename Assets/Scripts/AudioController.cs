using UnityEngine;


namespace PlayerPrefTest
{
    public class AudioController : MonoBehaviour
    {
		[SerializeField] AudioListener audioListener = null;



		void Awake()
		{
			AudioListener.volume = AudioLoader.LoadVolumeValue();
		}


		public static float GetActualVolume()
		{
			return AudioListener.volume;
		}
		public static void SetActualVolume(float value)
		{
			AudioListener.volume = value;
			AudioLoader.SaveVolumeValue(value);
		}
	}
}
