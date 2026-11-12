using UnityEngine;
using UnityEngine.Audio;

public class VolumeChanger : MonoBehaviour
{
    private AudioMixerGroup _audioMixerGroup;

    private float _volume;
    private string _groupName;

    public void SetGroupName(string groupName)
    {
        _groupName = groupName;
    }

    public void SetAudioMixerGroup(AudioMixerGroup audioMixerGroup)
    {
        _audioMixerGroup = audioMixerGroup;
    }

    public void SetVolumeValue(float volume)
    {
        int coefficient = 20;

        _volume = Mathf.Log10(volume) * coefficient;
    }

    public void ChangeVolume()
    {
        _audioMixerGroup.audioMixer.SetFloat(_groupName, _volume);
    }
}
