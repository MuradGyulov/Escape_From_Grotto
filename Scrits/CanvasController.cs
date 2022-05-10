using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class CanvasController : MonoBehaviour
{
    [Header("Texts on canvas")]
    [SerializeField] Text NumberOfbulletsText;
    [SerializeField] Text NumberOfCurrentScene;

    [SerializeField] GameObject WinPanel;
    [SerializeField] GameObject PausePanel;
    [SerializeField] GameObject LosePanel;

    private int sceneIndex;

    private void Start()
    {
        sceneIndex = SceneManager.GetActiveScene().buildIndex;
        NumberOfCurrentScene.text = "Level. " + sceneIndex.ToString();

        Player.SendPlayerBulletsNumber.AddListener(PlayersBulletsCounter);
        Player.SendPlayerDead.AddListener(LoseDelay);
        Player.PlayerPassedLevel.AddListener(PlayerWin);
    }

    private void LoseDelay()
    {
        Invoke("PlayerLose", 2f);

    }

    private void PlayersBulletsCounter(int currentBulletsNumber)
    {
        NumberOfbulletsText.text = currentBulletsNumber.ToString();
    }
  
    public void RestartLevel()
    {
        SceneManager.LoadScene(sceneIndex);
        Time.timeScale = 1;
    }

    public void CounntinueGame()
    {
        PausePanel.SetActive(false);
        Time.timeScale = 1;
    }

    public void GoToMainMenu()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;       
    }


    public void LoadNextLevel()
    {        
        

        SceneManager.LoadScene(sceneIndex + 1);
        Time.timeScale = 1;
    }

    private void IsendGame()
    {
        SceneManager.LoadScene(0);
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
        PausePanel.SetActive(true);       
    }

    private void PlayerLose()
    {
        LosePanel.SetActive(true);
        Time.timeScale = 0;
    }

    private void PlayerWin()
    {
        WinPanel.SetActive(true);
        Time.timeScale = 0;
    }
}
