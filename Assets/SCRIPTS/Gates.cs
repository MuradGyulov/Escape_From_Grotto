using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gates : MonoBehaviour
{
    [Header("Yandex AD SDK")]
    [SerializeField] YandexSDK ADPlayer;

    private int sceneIndex;
    private int completeLevels;

    private bool GatesCollision = false;

    private void Start()
    {
        sceneIndex = SceneManager.GetActiveScene().buildIndex;
        completeLevels = PlayerPrefs.GetInt("Completed_Levels");

        ADPlayer.ShowInterstitial();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Player" && GatesCollision == false)
        {
            GatesCollision = true;

            if (sceneIndex == 31)
            {
                PlayerPrefs.SetInt("Completed_Levels", sceneIndex);
                SceneManager.LoadScene(0);
            }
            else
            {
                if (completeLevels < sceneIndex)
                {
                    PlayerPrefs.SetInt("Completed_Levels", sceneIndex);
                    Invoke("Next_Level", 3f);
                }
            }
        }
    }

    private void Next_Level()
    {
        SceneManager.LoadScene(sceneIndex + 1);
    }
}
