using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMusic : MonoBehaviour
{
    [SerializeField] AudioSource audiosourcee;
    [SerializeField] private static PlayerMusic playerInstance;

    void Awake()
    {
        DontDestroyOnLoad(this);

        if (playerInstance == null)
        {
            playerInstance = this;
        }
        else
        {
            Object.Destroy(gameObject);
        }
    }

    public void changeVolume(float volume)
    {
        audiosourcee.volume = volume;
    }
}
