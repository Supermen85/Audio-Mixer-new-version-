using UnityEngine;
using UnityEngine.Audio;

public class MasterVolumeToggler : MonoBehaviour
{
    private AudioMixerGroup _audioMixerGroup;

    public bool IsEnable { get; private set; } = true;

    public void SetAudioMixerGroup(AudioMixerGroup audioMixerGroup)
    {
        _audioMixerGroup = audioMixerGroup;
    }

    public void TurnON()
    {
        IsEnable = true;
    }

    public void TurnOFF()
    {
        IsEnable = false;

        int volumeOFF = -80;

        _audioMixerGroup.audioMixer.SetFloat("MasterVolume", volumeOFF);
    }
}
