using UnityEngine;
using UnityEngine.Audio;

public class Menu : MonoBehaviour
{
    [SerializeField] private AudioMixerGroup _audioMixerGroup;

    [SerializeField] private MasterVolumeToggler _masterVolumeToggler;

    [SerializeField] private VolumeChanger _masterVolumeChanger;
    [SerializeField] private VolumeChanger _buttonsVolumeChanger;
    [SerializeField] private VolumeChanger _musicVolumeChanger;

    private void Awake()
    {
        _masterVolumeToggler.SetAudioMixerGroup(_audioMixerGroup);
        _masterVolumeChanger.SetAudioMixerGroup(_audioMixerGroup);
        _buttonsVolumeChanger.SetAudioMixerGroup(_audioMixerGroup);
        _musicVolumeChanger.SetAudioMixerGroup(_audioMixerGroup);

        _masterVolumeChanger.SetGroupName("MasterVolume");
        _buttonsVolumeChanger.SetGroupName("ButtonsVolume");
        _musicVolumeChanger.SetGroupName("MusicVolume");
    }

    public void ToggleMasterVolume()
    {
        if (_masterVolumeToggler.IsEnable)
        {
            _masterVolumeToggler.TurnOFF();
        }
        else
        {
            _masterVolumeToggler.TurnON();
            _masterVolumeChanger.ChangeVolume();
            _buttonsVolumeChanger.ChangeVolume();
            _musicVolumeChanger.ChangeVolume();
        }
    }

    public void ChangeMasterVolume(float volume)
    {
        _masterVolumeChanger.SetVolumeValue(volume);

        if (_masterVolumeToggler.IsEnable)
            _masterVolumeChanger.ChangeVolume();
    }

    public void ChangeButtonsVolume(float volume)
    {
        _buttonsVolumeChanger.SetVolumeValue(volume);

        if (_masterVolumeToggler.IsEnable)
            _buttonsVolumeChanger.ChangeVolume();
    }

    public void ChangeMusicVolume(float volume)
    {
        _musicVolumeChanger.SetVolumeValue(volume);

        if (_masterVolumeToggler.IsEnable)
            _musicVolumeChanger.ChangeVolume();
    }
}
