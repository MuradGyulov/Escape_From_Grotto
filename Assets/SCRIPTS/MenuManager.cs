using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{

    [Header("Main menu panels")]
    [SerializeField] GameObject LevelsPanel;
    [SerializeField] GameObject SettingsPanel;

    [Header("Sounds and Music sliders")]
    [SerializeField] Slider MusicSlider;
    [SerializeField] Slider SoundsSlider;


    [SerializeField] PlayerMusic muzPlayer;


    private int PlayerMusicVolumeSettings = 0;
    private int PlayerSoundsVolumeSettings = 0;

    [SerializeField] Button LV1;
    [SerializeField] Button LV2;
    [SerializeField] Button LV3;
    [SerializeField] Button LV4;
    [SerializeField] Button LV5;
    [SerializeField] Button LV6;
    [SerializeField] Button LV7;
    [SerializeField] Button LV8;
    [SerializeField] Button LV9;
    [SerializeField] Button LV10;
    [SerializeField] Button LV11;
    [SerializeField] Button LV12;
    [SerializeField] Button LV13;
    [SerializeField] Button LV14;
    [SerializeField] Button LV15;
    [SerializeField] Button LV16;
    [SerializeField] Button LV17;
    [SerializeField] Button LV18;
    [SerializeField] Button LV19;
    [SerializeField] Button LV20;
    [SerializeField] Button LV21;
    [SerializeField] Button LV22;
    [SerializeField] Button LV23;
    [SerializeField] Button LV24;
    [SerializeField] Button LV25;
    [SerializeField] Button LV26;
    [SerializeField] Button LV27;
    [SerializeField] Button LV28;
    [SerializeField] Button LV29;
    [SerializeField] Button LV30;
    [SerializeField] Button LV31;

    private void Start()
    {
        LV2.interactable = false;
        LV3.interactable = false;
        LV4.interactable = false;
        LV5.interactable = false;
        LV6.interactable = false;
        LV7.interactable = false;
        LV8.interactable = false;
        LV9.interactable = false;
        LV10.interactable = false;
        LV11.interactable = false;
        LV12.interactable = false;
        LV13.interactable = false;
        LV14.interactable = false;
        LV15.interactable = false;
        LV16.interactable = false;
        LV17.interactable = false;
        LV18.interactable = false;
        LV19.interactable = false;
        LV20.interactable = false;
        LV21.interactable = false;
        LV22.interactable = false;
        LV23.interactable = false;
        LV24.interactable = false;
        LV25.interactable = false;
        LV26.interactable = false;
        LV27.interactable = false;
        LV28.interactable = false;
        LV29.interactable = false;
        LV30.interactable = false;
        LV31.interactable = false;

        int completedLevels = PlayerPrefs.GetInt("Completed_Levels");

        switch (completedLevels)
        {
            case 2:
                LV2.interactable = true;
                LV3.interactable = true;
                break;
            case 3:
                LV2.interactable = true;
                LV3.interactable = true;
                LV4.interactable = true;
                break;
            case 4:
                LV2.interactable = true;
                LV3.interactable = true;
                LV4.interactable = true;
                LV5.interactable = true;
                break;
            case 5:
                LV2.interactable = true;
                LV3.interactable = true;
                LV4.interactable = true;
                LV5.interactable = true;
                LV6.interactable = true;
                break;
            case 6:
                LV2.interactable = true;
                LV3.interactable = true;
                LV4.interactable = true;
                LV5.interactable = true;
                LV6.interactable = true;
                LV7.interactable = true;
                break;
            case 7:
                LV2.interactable = true;
                LV3.interactable = true;
                LV4.interactable = true;
                LV5.interactable = true;
                LV6.interactable = true;
                LV7.interactable = true;
                LV8.interactable = true;
                break;
            case 8:
                LV2.interactable = true;
                LV3.interactable = true;
                LV4.interactable = true;
                LV5.interactable = true;
                LV6.interactable = true;
                LV7.interactable = true;
                LV8.interactable = true;
                LV9.interactable = true;
                break;
            case 9:
                LV2.interactable = true;
                LV3.interactable = true;
                LV4.interactable = true;
                LV5.interactable = true;
                LV6.interactable = true;
                LV7.interactable = true;
                LV8.interactable = true;
                LV9.interactable = true;
                LV10.interactable = true;
                break;
            case 10:
                LV2.interactable = true;
                LV3.interactable = true;
                LV4.interactable = true;
                LV5.interactable = true;
                LV6.interactable = true;
                LV7.interactable = true;
                LV8.interactable = true;
                LV9.interactable = true;
                LV10.interactable = true;
                LV11.interactable = true;
                break;
            case 11:
                LV2.interactable = true;
                LV3.interactable = true;
                LV4.interactable = true;
                LV5.interactable = true;
                LV6.interactable = true;
                LV7.interactable = true;
                LV8.interactable = true;
                LV9.interactable = true;
                LV10.interactable = true;
                LV11.interactable = true;
                LV12.interactable = true;
                break;
            case 12:
                LV2.interactable = true;
                LV3.interactable = true;
                LV4.interactable = true;
                LV5.interactable = true;
                LV6.interactable = true;
                LV7.interactable = true;
                LV8.interactable = true;
                LV9.interactable = true;
                LV10.interactable = true;
                LV11.interactable = true;
                LV12.interactable = true;
                LV13.interactable = true;
                break;
            case 13:
                LV2.interactable = true;
                LV3.interactable = true;
                LV4.interactable = true;
                LV5.interactable = true;
                LV6.interactable = true;
                LV7.interactable = true;
                LV8.interactable = true;
                LV9.interactable = true;
                LV10.interactable = true;
                LV11.interactable = true;
                LV12.interactable = true;
                LV13.interactable = true;
                LV14.interactable = true;
                break;
            case 14:
                LV2.interactable = true;
                LV3.interactable = true;
                LV4.interactable = true;
                LV5.interactable = true;
                LV6.interactable = true;
                LV7.interactable = true;
                LV8.interactable = true;
                LV9.interactable = true;
                LV10.interactable = true;
                LV11.interactable = true;
                LV12.interactable = true;
                LV13.interactable = true;
                LV14.interactable = true;
                LV15.interactable = true;
                break;
            case 15:
                LV2.interactable = true;
                LV3.interactable = true;
                LV4.interactable = true;
                LV5.interactable = true;
                LV6.interactable = true;
                LV7.interactable = true;
                LV8.interactable = true;
                LV9.interactable = true;
                LV10.interactable = true;
                LV11.interactable = true;
                LV12.interactable = true;
                LV13.interactable = true;
                LV14.interactable = true;
                LV15.interactable = true;
                LV16.interactable = true;
                break;
            case 16:
                LV2.interactable = true;
                LV3.interactable = true;
                LV4.interactable = true;
                LV5.interactable = true;
                LV6.interactable = true;
                LV7.interactable = true;
                LV8.interactable = true;
                LV9.interactable = true;
                LV10.interactable = true;
                LV11.interactable = true;
                LV12.interactable = true;
                LV13.interactable = true;
                LV14.interactable = true;
                LV15.interactable = true;
                LV16.interactable = true;
                LV17.interactable = true;
                break;
            case 17:
                LV2.interactable = true;
                LV3.interactable = true;
                LV4.interactable = true;
                LV5.interactable = true;
                LV6.interactable = true;
                LV7.interactable = true;
                LV8.interactable = true;
                LV9.interactable = true;
                LV10.interactable = true;
                LV11.interactable = true;
                LV12.interactable = true;
                LV13.interactable = true;
                LV14.interactable = true;
                LV15.interactable = true;
                LV16.interactable = true;
                LV17.interactable = true;
                LV18.interactable = true;
                break;
            case 18:
                LV2.interactable = true;
                LV3.interactable = true;
                LV4.interactable = true;
                LV5.interactable = true;
                LV6.interactable = true;
                LV7.interactable = true;
                LV8.interactable = true;
                LV9.interactable = true;
                LV10.interactable = true;
                LV11.interactable = true;
                LV12.interactable = true;
                LV13.interactable = true;
                LV14.interactable = true;
                LV15.interactable = true;
                LV16.interactable = true;
                LV17.interactable = true;
                LV18.interactable = true;
                LV19.interactable = true;
                break;
            case 19:
                LV2.interactable = true;
                LV3.interactable = true;
                LV4.interactable = true;
                LV5.interactable = true;
                LV6.interactable = true;
                LV7.interactable = true;
                LV8.interactable = true;
                LV9.interactable = true;
                LV10.interactable = true;
                LV11.interactable = true;
                LV12.interactable = true;
                LV13.interactable = true;
                LV14.interactable = true;
                LV15.interactable = true;
                LV16.interactable = true;
                LV17.interactable = true;
                LV18.interactable = true;
                LV19.interactable = true;
                LV20.interactable = true;
                break;
            case 20:
                LV2.interactable = true;
                LV3.interactable = true;
                LV4.interactable = true;
                LV5.interactable = true;
                LV6.interactable = true;
                LV7.interactable = true;
                LV8.interactable = true;
                LV9.interactable = true;
                LV10.interactable = true;
                LV11.interactable = true;
                LV12.interactable = true;
                LV13.interactable = true;
                LV14.interactable = true;
                LV15.interactable = true;
                LV16.interactable = true;
                LV17.interactable = true;
                LV18.interactable = true;
                LV19.interactable = true;
                LV20.interactable = true;
                LV21.interactable = true;
                break;
            case 21:
                LV2.interactable = true;
                LV3.interactable = true;
                LV4.interactable = true;
                LV5.interactable = true;
                LV6.interactable = true;
                LV7.interactable = true;
                LV8.interactable = true;
                LV9.interactable = true;
                LV10.interactable = true;
                LV11.interactable = true;
                LV12.interactable = true;
                LV13.interactable = true;
                LV14.interactable = true;
                LV15.interactable = true;
                LV16.interactable = true;
                LV17.interactable = true;
                LV18.interactable = true;
                LV19.interactable = true;
                LV20.interactable = true;
                LV21.interactable = true;
                LV22.interactable = true;
                break;
            case 22:
                LV2.interactable = true;
                LV3.interactable = true;
                LV4.interactable = true;
                LV5.interactable = true;
                LV6.interactable = true;
                LV7.interactable = true;
                LV8.interactable = true;
                LV9.interactable = true;
                LV10.interactable = true;
                LV11.interactable = true;
                LV12.interactable = true;
                LV13.interactable = true;
                LV14.interactable = true;
                LV15.interactable = true;
                LV16.interactable = true;
                LV17.interactable = true;
                LV18.interactable = true;
                LV19.interactable = true;
                LV20.interactable = true;
                LV21.interactable = true;
                LV22.interactable = true;
                LV23.interactable = true;
                break;
            case 23:
                LV2.interactable = true;
                LV3.interactable = true;
                LV4.interactable = true;
                LV5.interactable = true;
                LV6.interactable = true;
                LV7.interactable = true;
                LV8.interactable = true;
                LV9.interactable = true;
                LV10.interactable = true;
                LV11.interactable = true;
                LV12.interactable = true;
                LV13.interactable = true;
                LV14.interactable = true;
                LV15.interactable = true;
                LV16.interactable = true;
                LV17.interactable = true;
                LV18.interactable = true;
                LV19.interactable = true;
                LV20.interactable = true;
                LV21.interactable = true;
                LV22.interactable = true;
                LV23.interactable = true;
                LV24.interactable = true;
                break;
            case 24:
                LV2.interactable = true;
                LV3.interactable = true;
                LV4.interactable = true;
                LV5.interactable = true;
                LV6.interactable = true;
                LV7.interactable = true;
                LV8.interactable = true;
                LV9.interactable = true;
                LV10.interactable = true;
                LV11.interactable = true;
                LV12.interactable = true;
                LV13.interactable = true;
                LV14.interactable = true;
                LV15.interactable = true;
                LV16.interactable = true;
                LV17.interactable = true;
                LV18.interactable = true;
                LV19.interactable = true;
                LV20.interactable = true;
                LV21.interactable = true;
                LV22.interactable = true;
                LV23.interactable = true;
                LV24.interactable = true;
                LV25.interactable = true;
                break;
            case 25:
                LV2.interactable = true;
                LV3.interactable = true;
                LV4.interactable = true;
                LV5.interactable = true;
                LV6.interactable = true;
                LV7.interactable = true;
                LV8.interactable = true;
                LV9.interactable = true;
                LV10.interactable = true;
                LV11.interactable = true;
                LV12.interactable = true;
                LV13.interactable = true;
                LV14.interactable = true;
                LV15.interactable = true;
                LV16.interactable = true;
                LV17.interactable = true;
                LV18.interactable = true;
                LV19.interactable = true;
                LV20.interactable = true;
                LV21.interactable = true;
                LV22.interactable = true;
                LV23.interactable = true;
                LV24.interactable = true;
                LV25.interactable = true;
                LV26.interactable = true;
                break;
            case 26:
                LV2.interactable = true;
                LV3.interactable = true;
                LV4.interactable = true;
                LV5.interactable = true;
                LV6.interactable = true;
                LV7.interactable = true;
                LV8.interactable = true;
                LV9.interactable = true;
                LV10.interactable = true;
                LV11.interactable = true;
                LV12.interactable = true;
                LV13.interactable = true;
                LV14.interactable = true;
                LV15.interactable = true;
                LV16.interactable = true;
                LV17.interactable = true;
                LV18.interactable = true;
                LV19.interactable = true;
                LV20.interactable = true;
                LV21.interactable = true;
                LV22.interactable = true;
                LV23.interactable = true;
                LV24.interactable = true;
                LV25.interactable = true;
                LV26.interactable = true;
                LV27.interactable = true;
                break;
            case 27:
                LV2.interactable = true;
                LV3.interactable = true;
                LV4.interactable = true;
                LV5.interactable = true;
                LV6.interactable = true;
                LV7.interactable = true;
                LV8.interactable = true;
                LV9.interactable = true;
                LV10.interactable = true;
                LV11.interactable = true;
                LV12.interactable = true;
                LV13.interactable = true;
                LV14.interactable = true;
                LV15.interactable = true;
                LV16.interactable = true;
                LV17.interactable = true;
                LV18.interactable = true;
                LV19.interactable = true;
                LV20.interactable = true;
                LV21.interactable = true;
                LV22.interactable = true;
                LV23.interactable = true;
                LV24.interactable = true;
                LV25.interactable = true;
                LV26.interactable = true;
                LV27.interactable = true;
                LV28.interactable = true;
                break;
            case 28:
                LV2.interactable = true;
                LV3.interactable = true;
                LV4.interactable = true;
                LV5.interactable = true;
                LV6.interactable = true;
                LV7.interactable = true;
                LV8.interactable = true;
                LV9.interactable = true;
                LV10.interactable = true;
                LV11.interactable = true;
                LV12.interactable = true;
                LV13.interactable = true;
                LV14.interactable = true;
                LV15.interactable = true;
                LV16.interactable = true;
                LV17.interactable = true;
                LV18.interactable = true;
                LV19.interactable = true;
                LV20.interactable = true;
                LV21.interactable = true;
                LV22.interactable = true;
                LV23.interactable = true;
                LV24.interactable = true;
                LV25.interactable = true;
                LV26.interactable = true;
                LV27.interactable = true;
                LV28.interactable = true;
                LV29.interactable = true;
                break;
            case 29:
                LV2.interactable = true;
                LV3.interactable = true;
                LV4.interactable = true;
                LV5.interactable = true;
                LV6.interactable = true;
                LV7.interactable = true;
                LV8.interactable = true;
                LV9.interactable = true;
                LV10.interactable = true;
                LV11.interactable = true;
                LV12.interactable = true;
                LV13.interactable = true;
                LV14.interactable = true;
                LV15.interactable = true;
                LV16.interactable = true;
                LV17.interactable = true;
                LV18.interactable = true;
                LV19.interactable = true;
                LV20.interactable = true;
                LV21.interactable = true;
                LV22.interactable = true;
                LV23.interactable = true;
                LV24.interactable = true;
                LV25.interactable = true;
                LV26.interactable = true;
                LV27.interactable = true;
                LV28.interactable = true;
                LV29.interactable = true;
                LV30.interactable = true;
                break;
            case 30:
                LV2.interactable = true;
                LV3.interactable = true;
                LV4.interactable = true;
                LV5.interactable = true;
                LV6.interactable = true;
                LV7.interactable = true;
                LV8.interactable = true;
                LV9.interactable = true;
                LV10.interactable = true;
                LV11.interactable = true;
                LV12.interactable = true;
                LV13.interactable = true;
                LV14.interactable = true;
                LV15.interactable = true;
                LV16.interactable = true;
                LV17.interactable = true;
                LV18.interactable = true;
                LV19.interactable = true;
                LV20.interactable = true;
                LV21.interactable = true;
                LV22.interactable = true;
                LV23.interactable = true;
                LV24.interactable = true;
                LV25.interactable = true;
                LV26.interactable = true;
                LV27.interactable = true;
                LV28.interactable = true;
                LV29.interactable = true;
                LV30.interactable = true;
                LV31.interactable = true;
                break;
            case 31:
                LV2.interactable = true;
                LV3.interactable = true;
                LV4.interactable = true;
                LV5.interactable = true;
                LV6.interactable = true;
                LV7.interactable = true;
                LV8.interactable = true;
                LV9.interactable = true;
                LV10.interactable = true;
                LV11.interactable = true;
                LV12.interactable = true;
                LV13.interactable = true;
                LV14.interactable = true;
                LV15.interactable = true;
                LV16.interactable = true;
                LV17.interactable = true;
                LV18.interactable = true;
                LV19.interactable = true;
                LV20.interactable = true;
                LV21.interactable = true;
                LV22.interactable = true;
                LV23.interactable = true;
                LV24.interactable = true;
                LV25.interactable = true;
                LV26.interactable = true;
                LV27.interactable = true;
                LV28.interactable = true;
                LV29.interactable = true;
                LV30.interactable = true;
                LV31.interactable = true;
                break;        
        }


        muzPlayer = GameObject.FindGameObjectWithTag("MusicPlayer").gameObject.GetComponent<PlayerMusic>();

        PlayerMusicVolumeSettings = PlayerPrefs.GetInt("User music settings");
        PlayerSoundsVolumeSettings = PlayerPrefs.GetInt("User sounds settings");


        
        SoundsSlider.value = 1f;

        if (PlayerMusicVolumeSettings == 1)
        {
            MusicSlider.value = PlayerPrefs.GetFloat("Music volume");
        }
        else if(PlayerMusicVolumeSettings == 0)
        {
            MusicSlider.value = 0.2f;
        }

        if(PlayerSoundsVolumeSettings == 1)
        {
            SoundsSlider.value = PlayerPrefs.GetFloat("Sounds volume");
        }
        else if(PlayerSoundsVolumeSettings == 0)
        {
            SoundsSlider.value = 1f;
        }
    }


    public void MusicVolumeSlider()
    {
        float musicVolume = MusicSlider.value;
        muzPlayer.changeVolume(musicVolume);
        PlayerPrefs.SetFloat("Music volume", musicVolume);
        PlayerMusicVolumeSettings = 1;
        PlayerPrefs.SetInt("User music settings", PlayerMusicVolumeSettings);
    }
    public void SoundsVolumeSlider()
    {
        float soundsVolume = SoundsSlider.value;
        PlayerPrefs.SetFloat("Sounds volume", soundsVolume);
        PlayerSoundsVolumeSettings = 1;
        PlayerPrefs.SetInt("User sounds settings", PlayerMusicVolumeSettings);
    }
    
    public void OpenLevelsPanel()
    {
        SettingsPanel.SetActive(false);
        LevelsPanel.SetActive(true);
    }

    public void OpenSettingsPanel()
    {
        SettingsPanel.SetActive(true);
    }

    public void BackToMenu()
    {
        LevelsPanel.SetActive(false);
        SettingsPanel.SetActive(false);
    }

    public void LoadLevel(int levelIndex)
    {
        SceneManager.LoadScene(levelIndex);
    }
}
