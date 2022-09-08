using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{


    public GameObject player;
    public GameObject playButton;
    public GameObject gameOverText;
    public Text timerText;
    //public ParticleSystem particles;


    private float step = 0.01f;
    public void Start()
    {
        Resume();
        gameOverText.SetActive(false);
        timerText.enabled = false;
    }

    private void Pause()
    {
        Time.timeScale = 0;
        playButton.SetActive(true);

    }

    public void Resume()
    {
        playButton.SetActive(false);
        Time.timeScale = 1;
        player.SetActive(true);
    }

    public void GameOver()
    {
        StartCoroutine(TimeRoutine());
        RestartLevel();
        //todo text game over
    }

    private void RestartLevel() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void GameComplete()
    {
        RestartLevel();
        //congrats
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            Pause();
        }
    }

    IEnumerator TimeRoutine()
    {
        yield return new WaitForSecondsRealtime(4);

    }
}
