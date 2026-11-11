using UnityEngine;
using UnityEngine.Audio;

public class Menu : MonoBehaviour
{
    [SerializeField] private AudioMixerGroup _audioMixerGroup;

    private bool _isMasterVolumeEnable = true;

    private float _masterVolume;
    private float _buttonsVolume;
    private float _musicVolume;

    public void ToggleMasterVolue()
    {
        int volumeOFF = -80;

        if (_isMasterVolumeEnable)
        {
            _isMasterVolumeEnable = false;
            _audioMixerGroup.audioMixer.SetFloat("MasterVolume", volumeOFF);
        }
        else
        {
            _isMasterVolumeEnable = true;
            _audioMixerGroup.audioMixer.SetFloat("MasterVolume", _masterVolume);
            _audioMixerGroup.audioMixer.SetFloat("ButtonsVolume", _buttonsVolume);
            _audioMixerGroup.audioMixer.SetFloat("MusicVolume", _musicVolume);
        }
    }

    public void ChangeMasterVolume(float volume)
    {
        int coefficient = 20;

        _masterVolume = Mathf.Log10(volume) * coefficient;
        
        if (_isMasterVolumeEnable)
            _audioMixerGroup.audioMixer.SetFloat("MasterVolume", _masterVolume);
    }

    public void ChangeButtonsVolume(float volume)
    {
        int coefficient = 20;

        _buttonsVolume = Mathf.Log10(volume) * coefficient;
       
        if (_isMasterVolumeEnable)
            _audioMixerGroup.audioMixer.SetFloat("ButtonsVolume", _buttonsVolume);
    }

    public void ChangeMusicVolume(float volume)
    {
        int coefficient = 20;

        _musicVolume = Mathf.Log10(volume) * coefficient;

        if (_isMasterVolumeEnable)
            _audioMixerGroup.audioMixer.SetFloat("MusicVolume", _musicVolume);
    }
}
