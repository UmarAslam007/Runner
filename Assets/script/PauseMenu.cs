using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    public Slider slider;

    public AudioSource clickSound;
    public AudioSource jumpSound;
    public AudioSource BackGroundSound;

    private void Start()
    {
        if (PlayerPrefs.HasKey("GameVol"))
        {
            BackGroundSound.volume = slider.value = PlayerPrefs.GetFloat("GameVol");
        }
    }

    public void Pause()
    {
        if(jumpSound.isPlaying)
        {
            jumpSound.Stop();
        }
        clickSound.Play();
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Resume()
    {
        if (jumpSound.isPlaying)
        {
            jumpSound.Stop();
        }
        clickSound.Play();
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
    }

    public void Restart()
    {
        clickSound.Play();
        Time.timeScale = 1f;
    }

    public void Home()
    {
        clickSound.Play();
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void Setting()
    {
        clickSound.Play();
      
    }

    public void Back()
    {
        clickSound.Play();

    }

    public void Volume()
    {
        BackGroundSound.volume = slider.value;
        PlayerPrefs.SetFloat("GameVol", slider.value);
    }

}
