using UnityEngine;


namespace PlayerPrefTest
{
    public static class AudioLoader
    {
        const string volumeValueKey = "Volume";
        const float defaultVolume = 1.0f;

        static float actualVolume;

        

        public static float LoadVolumeValue()
		{
            if (PlayerPrefs.HasKey(volumeValueKey))
            {
                actualVolume = PlayerPrefs.GetFloat(volumeValueKey);
            }
            else
            {
                actualVolume = defaultVolume;
            }

            return actualVolume;
        }
        public static void SaveVolumeValue(float value)
		{
            PlayerPrefs.SetFloat(volumeValueKey, value);
        }
    }
}
